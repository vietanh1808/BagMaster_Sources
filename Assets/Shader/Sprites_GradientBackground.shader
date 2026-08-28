Shader "Sprites/GradientBackground" {
	Properties {
		_MainTex ("Sprite Texture", 2D) = "white" {}
		_Color0 ("Color 0", Vector) = (1,1,1,1)
		_Color1 ("Color 1", Vector) = (0.75,0.75,0.75,1)
		_Color2 ("Color 2", Vector) = (0.5,0.5,0.5,1)
		_Color3 ("Color 3", Vector) = (0.25,0.25,0.25,1)
		_Color4 ("Color 4", Vector) = (0,0,0,1)
		_ColorCount ("Number of Colors Used", Float) = 5
		_GradientAngle ("Gradient Angle (degrees)", Float) = 90
		_Repeat ("Gradient Repeat", Float) = 2
		_Speed ("Movement Speed", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
}