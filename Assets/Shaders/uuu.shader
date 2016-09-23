Shader "Custom/uuu" {

    Properties
    {
        _RegularColor("Main Color", Color) = (1, 1, 1, 1) //Color when not intersecting
        _HighlightColor("Highlight Color", Color) = (1, 1, 1, 1) //Color when intersecting
        _DeepnessColor("Deepness Color", Color) = (1, 1, 1, 1) 


        _HighlightThresholdMax("Highlight Threshold Max", Float) = 1 //Max difference for intersections
        _DeepnessThresholdMax("Deepness Threshold Max", Float) = 1 

        _N1("N1", Float) = 1 //Max difference for intersections
        _N2("N2", Float) = 1
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" "RenderType"="Transparent"  }
 
        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            Cull Off
 
            CGPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            uniform sampler2D _CameraDepthTexture; //Depth Texture
            uniform float4 _RegularColor;
            uniform float4 _HighlightColor;
            uniform float4 _DeepnessColor;

            uniform float _HighlightThresholdMax;
            uniform float _DeepnessThresholdMax;
            uniform float _N1;
            uniform float _N2;
 
            struct v2f
            {
                float4 pos : SV_POSITION;
                float4 projPos : TEXCOORD1; //Screen position of pos
            };
 
            v2f vert(appdata_base v)
            {
                v2f o;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                o.projPos = ComputeScreenPos(o.pos);
 
                return o;
            }
 
            half4 frag(v2f i) : COLOR
            {

           		float4 DeepColor = _RegularColor;
                float4 finalColor = _RegularColor;
 
                //Get the distance to the camera from the depth buffer for this point
                float sceneZ = LinearEyeDepth (tex2Dproj(_CameraDepthTexture,
                                                         UNITY_PROJ_COORD(i.projPos)).r);
 
                //Actual distance to the camera
                float partZ = i.projPos.z;
 
                //If the two are similar, then there is an object intersecting with our object
                float DeepnessDiff = (abs(sceneZ - partZ)-_DeepnessThresholdMax) /_N2  ;

                float diff = (abs(sceneZ - partZ) -
                	_HighlightThresholdMax) /_N1 ;




                if(DeepnessDiff <= 1 && DeepnessDiff >= 0)
                {

                    finalColor = lerp(_DeepnessColor, _RegularColor,
                   					 
                    				  
                    				  float4(.3/DeepnessDiff,.3/DeepnessDiff,.3/DeepnessDiff,1-DeepnessDiff));

                }else if(DeepnessDiff >= 1)
                {
                	 finalColor =_DeepnessColor;

                }


                if(diff <= 1)
                {

                   finalColor  = lerp(_HighlightColor,
                                      finalColor,
                                      float4(diff, diff, diff, diff));
                }
 
 

                half4 c;
                c.r = finalColor.r;
                c.g = finalColor.g;
                c.b = finalColor.b;
                c.a = finalColor.a*0.9f;
 
                return c;
            }
 
            ENDCG
        }
    }
    FallBack "VertexLit"
}
