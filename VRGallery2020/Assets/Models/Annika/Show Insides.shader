Shader "Custom/ShowInsides" {
	Properties{
	_Color("Color", Color) = (1,1,1)
	_MainTex("Texture", 2D) = "white" {}
	}

	SubShader {
		Color[_Color]
		Pass {
			Material {
				Diffuse[_Color]
			}
			Lighting Off
			Cull Front
		}
	}
}