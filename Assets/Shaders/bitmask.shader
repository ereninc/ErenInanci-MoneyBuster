// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/bitmask" {
    Properties
    {
        _Color("Color", Color) = (1, 1, 1, 0.5)
        _ForceField("Force Field Position", Vector) = (0, 0, 0)
    }

    SubShader
    {
        Tags
        { 
            "Queue" = "Geometry"
        }

        Pass
        {

            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            uniform float4 _Color;
            uniform float4 _ForceField;

            struct vertexInput 
            {
                float4 vertex : POSITION;
            };

            struct vertexOutput 
            {
                float4 pos : SV_POSITION;
                float4 worldPos : TEXCOORD0;
            };

            vertexOutput vert(vertexInput input) {
                vertexOutput output;

                float4x4 modelMatrix = unity_ObjectToWorld;

                output.pos = UnityObjectToClipPos(input.vertex);
                output.worldPos = mul(modelMatrix, input.vertex);

                return output;
            }

            float4 frag(vertexOutput input) : COLOR{
                float4 color = _Color;
                if (distance(input.worldPos, _ForceField) > 2.7)
                    color = float4(0.0,0.0,0.0,1.0);
                return float4 (color);
            }
            ENDCG
        }
    }
}