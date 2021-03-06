#include "efk.LineRenderer.h"

#ifdef _WIN32
#include "Platform/DX9/efk.LineRendererDX9.h"
#endif

#include "Platform/GL/efk.LineRendererGL.h"

namespace efk
{
	LineRenderer* LineRenderer::Create(Graphics* graphics)
	{
#ifdef _WIN32
		if (graphics->GetDeviceType() == DeviceType::DirectX9)
		{
			return new LineRendererDX9(graphics->GetRenderer());
		}
#endif
		if (graphics->GetDeviceType() == DeviceType::OpenGL)
		{
			return new LineRendererGL(graphics->GetRenderer());
		}

		return nullptr;
	}
}