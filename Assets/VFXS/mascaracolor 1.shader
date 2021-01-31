// Directorio /Nombre del Shader
Shader "Custom/mascaracolor1"
{
	// Variables disponibles en el inspector (propiedades)
	Properties
	{
		_Textura1("Textura (RGB) ", 2D) = "White" {}
		_Textura2("Textura (RGB) ", 2D) = "White" {}
		_Normal("Normal (RGB) ", 2D) = "Bump" {}
		_Color("Color", color) = (1,1,1,1)
	}

		// Primer subshader
			SubShader
		{
			Tags{ "RenderType" = "Opaque" }
			LOD 200

			CGPROGRAM
			// Asignación de métodos y selección de parametros
			#pragma surface surf Standard fullforwardshadows
			#pragma target 3.0

			// Declaración de variables
			sampler2D _Textura1;
			sampler2D _Textura2;
			sampler2D _Normal;
			float4 _Color;

			// Información adicional provista por el juego
			struct Input
			{
				float2 uv_Textura1;
			};

			// Nucleo del programa
			void surf(Input IN, inout SurfaceOutputStandard o)
			{
				float3 c1 = tex2D(_Textura1, IN.uv_Textura1);
				float3 c2 = tex2D(_Textura2, IN.uv_Textura1);
				float3 c3 = c1 * (1 - c2);
				float3 c4 = _Color * c2;
				float3 c = c3 + c4;
				o.Albedo = c.rgb;

				float4 n = tex2D(_Normal, IN.uv_Textura1);
				float3 normal = UnpackNormal(n).rgb;
				normal.rg *= 2;
				o.Normal = normalize(normal);
			}
			ENDCG
		}// Final del primer subshader

		// Segundo subshader si existe alguno
		// Tercer subshader...

		// Si no es posible ejecutar ningún subshader use Diffuse
				FallBack "Diffuse"
}