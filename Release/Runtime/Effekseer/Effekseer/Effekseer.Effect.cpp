

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
#include "Effekseer.Effect.h"
#include "Effekseer.EffectImplemented.h"
#include "Effekseer.Manager.h"
#include "Effekseer.ManagerImplemented.h"
#include "Effekseer.EffectNode.h"
#include "Effekseer.EffectLoader.h"
#include "Effekseer.TextureLoader.h"
#include "Effekseer.SoundLoader.h"
#include "Effekseer.ModelLoader.h"

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
namespace Effekseer
{

static void PathCombine(EFK_CHAR* dst, const EFK_CHAR* src1, const EFK_CHAR* src2)
{
	int len1 = 0, len2 = 0;
	if( src1 != NULL )
	{
		for( len1 = 0; src1[len1] != L'\0'; len1++ ) {}
		memcpy( dst, src1, len1 * sizeof(EFK_CHAR) );
		if( len1 > 0 && src1[len1 - 1] != L'/' && src1[len1 - 1] != L'\\' )
		{
			dst[len1++] = L'/';
		}
	}
	if( src2 != NULL)
	{
		for( len2 = 0; src2[len2] != L'\0'; len2++ ) {}
		memcpy( &dst[len1], src2, len2 * sizeof(EFK_CHAR) );
	}
	dst[len1 + len2] = L'\0';
}

static void GetParentDir(EFK_CHAR* dst, const EFK_CHAR* src)
{
	int i, last = -1;
	for( i = 0; src[i] != L'\0'; i++ )
	{
		if( src[i] == L'/' || src[i] == L'\\' )
			last = i;
	}
	if( last >= 0 )
	{
		memcpy( dst, src, last * sizeof(EFK_CHAR) );
		dst[last] = L'\0';
	}
	else
	{
		dst[0] = L'\0';
	}
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
Effect* Effect::Create( Manager* manager, void* data, int32_t size, float magnification, const EFK_CHAR* materialPath )
{
	return EffectImplemented::Create( manager, data, size, magnification, materialPath );
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
Effect* Effect::Create( Manager* manager, const EFK_CHAR* path, float magnification, const EFK_CHAR* materialPath )
{
	EffectLoader* loader = manager->GetEffectLoader();
	if( loader == NULL ) return NULL;

	void* data = NULL;
	int32_t size = 0;

	if( !loader->Load( path, data, size ) ) return NULL;

	EFK_CHAR parentDir[512];
	if( materialPath == NULL )
	{
		GetParentDir(parentDir, path);
		materialPath = parentDir;
	}

	Effect* effect = EffectImplemented::Create( manager, data, size, magnification, materialPath );

	loader->Unload( data, size );

	return effect;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
Effect* EffectImplemented::Create( Manager* pManager, void* pData, int size, float magnification, const EFK_CHAR* materialPath )
{
	if( pData == NULL || size == 0 ) return NULL;

	EffectImplemented* effect = new EffectImplemented( pManager, pData, size );
	effect->Load( pData, size, magnification, materialPath );
	return effect;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
EffectImplemented::EffectImplemented( Manager* pManager, void* pData, int size )
	: m_pManager		( (ManagerImplemented*)pManager )
	, m_isInitialized	( false )
	, m_reference		( 1 )
	, m_version			( 0 )
	, m_ImageCount		( 0 )
	, m_ImagePaths		( NULL )
	, m_pImages			( NULL )
	, m_WaveCount		( 0 )
	, m_WavePaths		( NULL )
	, m_pWaves			( NULL )
	, m_modelCount		( 0 )
	, m_modelPaths		( NULL )
	, m_pModels			( NULL )
	, m_maginification	( 1.0f )
	, m_maginificationExternal	( 1.0f )
	, m_pRoot			( NULL )
{
	ES_SAFE_ADDREF( m_pManager );
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
EffectImplemented::~EffectImplemented()
{
	Reset();

	ES_SAFE_RELEASE( m_pManager );
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
EffectNode* EffectImplemented::GetRoot() const
{
	return m_pRoot;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
float EffectImplemented::GetMaginification() const
{
	return m_maginification;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
bool EffectImplemented::IsInitialized() const
{
	return m_isInitialized;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void EffectImplemented::Load( void* pData, int size, float mag, const EFK_CHAR* materialPath )
{
	EffekseerPrintDebug("** Create : Effect\n");

	uint8_t* pos = (uint8_t*)pData;

	// EFKS
	int head = 0;
	memcpy( &head, pos, sizeof(int) );
	if( memcmp( &head, "SKFE", 4 ) != 0 ) return;
	pos += sizeof( int );

	memcpy( &m_version, pos, sizeof(int) );
	pos += sizeof(int);

	// �摜
	memcpy( &m_ImageCount, pos, sizeof(int) );
	pos += sizeof(int);

	if( m_ImageCount > 0 )
	{
		m_ImagePaths = new EFK_CHAR*[ m_ImageCount ];
		m_pImages = new void*[ m_ImageCount ];

		for( int i = 0; i < m_ImageCount; i++ )
		{
			int length = 0;
			memcpy( &length, pos, sizeof(int) );
			pos += sizeof(int);

			m_ImagePaths[i] = new EFK_CHAR[ length ];
			memcpy( m_ImagePaths[i], pos, length * sizeof(EFK_CHAR) );
			pos += length * sizeof(EFK_CHAR);

			m_pImages[i] = NULL;
		}
	}

	if( m_version >= 1 )
	{
		// �E�F�[�u
		memcpy( &m_WaveCount, pos, sizeof(int) );
		pos += sizeof(int);

		if( m_WaveCount > 0 )
		{
			m_WavePaths = new EFK_CHAR*[ m_WaveCount ];
			m_pWaves = new void*[ m_WaveCount ];

			for( int i = 0; i < m_WaveCount; i++ )
			{
				int length = 0;
				memcpy( &length, pos, sizeof(int) );
				pos += sizeof(int);

				m_WavePaths[i] = new EFK_CHAR[ length ];
				memcpy( m_WavePaths[i], pos, length * sizeof(EFK_CHAR) );
				pos += length * sizeof(EFK_CHAR);

				m_pWaves[i] = NULL;
			}
		}
	}

	if( m_version >= 6 )
	{
		/* ���f�� */
		memcpy( &m_modelCount, pos, sizeof(int) );
		pos += sizeof(int);

		if( m_modelCount > 0 )
		{
			m_modelPaths = new EFK_CHAR*[ m_modelCount ];
			m_pModels = new void*[ m_modelCount ];

			for( int i = 0; i < m_modelCount; i++ )
			{
				int length = 0;
				memcpy( &length, pos, sizeof(int) );
				pos += sizeof(int);

				m_modelPaths[i] = new EFK_CHAR[ length ];
				memcpy( m_modelPaths[i], pos, length * sizeof(EFK_CHAR) );
				pos += length * sizeof(EFK_CHAR);

				m_pModels[i] = NULL;
			}
		}
	}

	// �g�嗦
	if( m_version >= 2 )
	{
		memcpy( &m_maginification, pos, sizeof(float) );
		pos += sizeof(float);
		m_maginification *= mag;
		m_maginificationExternal = mag;
	}

	// �m�[�h
	m_pRoot = EffectNode::Create( this, pos );

	ReloadResources( materialPath );

	Initialize();
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void EffectImplemented::Initialize()
{
	m_isInitialized = true;

	m_pRoot->Initialize();
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void EffectImplemented::Reset()
{
	UnloadResources();

	TextureLoader* textureLoader = m_pManager->GetTextureLoader();

	for( int i = 0; i < m_ImageCount; i++ )
	{
		if( m_ImagePaths[i] != NULL ) delete [] m_ImagePaths[i];
	}

	m_ImageCount = 0;

	ES_SAFE_DELETE_ARRAY( m_ImagePaths );
	ES_SAFE_DELETE_ARRAY( m_pImages );

	for( int i = 0; i < m_WaveCount; i++ )
	{
		if( m_WavePaths[i] != NULL ) delete [] m_WavePaths[i];
	}
	m_WaveCount = 0;

	ES_SAFE_DELETE_ARRAY( m_WavePaths );
	ES_SAFE_DELETE_ARRAY( m_pWaves );

	for( int i = 0; i < m_modelCount; i++ )
	{
		if( m_modelPaths[i] != NULL ) delete [] m_modelPaths[i];
	}
	m_modelCount = 0;

	ES_SAFE_DELETE_ARRAY( m_modelPaths );
	ES_SAFE_DELETE_ARRAY( m_pModels );

	ES_SAFE_DELETE( m_pRoot );

	m_isInitialized = false;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
int EffectImplemented::AddRef()
{
	m_reference++;
	return m_reference;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
int EffectImplemented::Release()
{
	m_reference--;
	int count = m_reference;
	if ( count == 0 )
	{
		delete this;
	}
	return count;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
Manager* EffectImplemented::GetManager() const
{
	return m_pManager;	
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
int EffectImplemented::GetVersion() const
{
	return m_version;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void* EffectImplemented::GetImage( int n ) const
{
	return m_pImages[ n ];
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void* EffectImplemented::GetWave( int n ) const
{
	return m_pWaves[ n ];
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void* EffectImplemented::GetModel( int n ) const
{
	return m_pModels[ n ];
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
bool EffectImplemented::Reload( void* data, int32_t size, const EFK_CHAR* materialPath )
{
	m_pManager->BeginReloadEffect( this );

	Reset();
	Load( data, size, m_maginificationExternal, materialPath );

	m_pManager->EndReloadEffect( this );

	return false;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
bool EffectImplemented::Reload( const EFK_CHAR* path, const EFK_CHAR* materialPath )
{
	EffectLoader* loader = m_pManager->GetEffectLoader();
	if( loader == NULL ) return false;

	void* data = NULL;
	int32_t size = 0;

	if( !loader->Load( path, data, size ) ) return false;

	EFK_CHAR parentDir[512];
	if( materialPath == NULL )
	{
		GetParentDir(parentDir, path);
		materialPath = parentDir;
	}

	m_pManager->BeginReloadEffect( this );

	Reset();
	Load( data, size, m_maginificationExternal, materialPath );

	m_pManager->EndReloadEffect( this );

	loader->Unload( data, size );

	return false;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void EffectImplemented::ReloadResources( const EFK_CHAR* materialPath )
{
	UnloadResources();

	{
		TextureLoader* textureLoader = m_pManager->GetTextureLoader();
		if( textureLoader != NULL )
		{
			for( int32_t ind = 0; ind < m_ImageCount; ind++ )
			{
				EFK_CHAR fullPath[512];
				PathCombine( fullPath, materialPath, m_ImagePaths[ ind ] );
				m_pImages[ind] = textureLoader->Load( fullPath );
			}
		}
	}

	{
		SoundLoader* soundLoader = m_pManager->GetSoundLoader();
		if( soundLoader != NULL )
		{
			for( int32_t ind = 0; ind < m_WaveCount; ind++ )
			{
				EFK_CHAR fullPath[512];
				PathCombine( fullPath, materialPath, m_WavePaths[ ind ] );
				m_pWaves[ind] = soundLoader->Load( fullPath );
			}
		}
	}

	{
		ModelLoader* modelLoader = m_pManager->GetModelLoader();
		
		if( modelLoader != NULL )
		{
			for( int32_t ind = 0; ind < m_modelCount; ind++ )
			{
				EFK_CHAR fullPath[512];
				PathCombine( fullPath, materialPath, m_modelPaths[ ind ] );
				m_pModels[ind] = modelLoader->Load( fullPath );
			}
		}
	}
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
void EffectImplemented::UnloadResources()
{
	TextureLoader* textureLoader = m_pManager->GetTextureLoader();
	if( textureLoader != NULL )
	{
		for( int32_t ind = 0; ind < m_ImageCount; ind++ )
		{
			textureLoader->Unload( m_pImages[ind] );
			m_pImages[ind] = NULL;
		}
	}

	SoundLoader* soundLoader = m_pManager->GetSoundLoader();
	if( soundLoader != NULL )
	{
		for( int32_t ind = 0; ind < m_WaveCount; ind++ )
		{
			soundLoader->Unload( m_pWaves[ind] );
			m_pWaves[ind] = NULL;
		}
	}

	{
		ModelLoader* modelLoader = m_pManager->GetModelLoader();
		if( modelLoader != NULL )
		{
			for( int32_t ind = 0; ind < m_modelCount; ind++ )
			{
				modelLoader->Unload( m_pModels[ind] );
				m_pModels[ind] = NULL;
			}
		}
	}

	m_isInitialized = false;
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------
}

//----------------------------------------------------------------------------------
//
//----------------------------------------------------------------------------------