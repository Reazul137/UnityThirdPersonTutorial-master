// Shader created with Shader Forge v1.16 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.16;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:False,rfrpn:Refraction,ufog:False,aust:False,igpj:False,qofs:0,qpre:2,rntp:9,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:4013,x:33158,y:32642,varname:node_4013,prsc:2|diff-3158-RGB,clip-723-OUT,voffset-6215-OUT;n:type:ShaderForge.SFN_Tex2d,id:7533,x:32289,y:32743,ptovrint:False,ptlb:Mask,ptin:_Mask,varname:node_7533,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3283ff8aeafaf6342bb40bacf58614de,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Time,id:7593,x:31301,y:32759,varname:node_7593,prsc:2;n:type:ShaderForge.SFN_Multiply,id:826,x:31579,y:32857,varname:node_826,prsc:2|A-7593-T,B-9367-OUT;n:type:ShaderForge.SFN_Add,id:6410,x:31850,y:33048,varname:node_6410,prsc:2|A-826-OUT,B-6885-OUT;n:type:ShaderForge.SFN_Sin,id:6787,x:32056,y:33048,varname:node_6787,prsc:2|IN-6410-OUT;n:type:ShaderForge.SFN_Multiply,id:5045,x:32382,y:33048,varname:node_5045,prsc:2|A-6787-OUT,B-7947-OUT,C-1857-OUT;n:type:ShaderForge.SFN_ComponentMask,id:8115,x:32548,y:33038,varname:node_8115,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-5045-OUT;n:type:ShaderForge.SFN_Multiply,id:6215,x:32796,y:33038,varname:node_6215,prsc:2|A-8115-OUT,B-6622-OUT;n:type:ShaderForge.SFN_Vector3,id:6622,x:32548,y:33222,varname:node_6622,prsc:2,v1:1,v2:0,v3:1;n:type:ShaderForge.SFN_Slider,id:6358,x:31966,y:32931,ptovrint:False,ptlb:GrassAmont,ptin:_GrassAmont,varname:node_6358,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.4,cur:-0.4,max:0.4;n:type:ShaderForge.SFN_Slider,id:7947,x:31226,y:33416,ptovrint:False,ptlb:WindAmont,ptin:_WindAmont,varname:node_7947,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1434368,max:0.5;n:type:ShaderForge.SFN_Slider,id:9367,x:31121,y:32935,ptovrint:False,ptlb:WindSpeed,ptin:_WindSpeed,varname:node_9367,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2.256611,max:5;n:type:ShaderForge.SFN_Round,id:1857,x:32114,y:33330,varname:node_1857,prsc:2|IN-6885-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:1548,x:30510,y:33013,varname:node_1548,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:5497,x:30340,y:33132,varname:node_5497,prsc:2;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:6885,x:31029,y:33156,varname:node_6885,prsc:2|IN-1548-Y,IMIN-5497-Y,IMAX-6132-OUT,OMIN-4515-OUT,OMAX-9156-OUT;n:type:ShaderForge.SFN_Vector1,id:4515,x:30712,y:33348,varname:node_4515,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:9156,x:30712,y:33407,varname:node_9156,prsc:2,v1:1;n:type:ShaderForge.SFN_ObjectScale,id:3708,x:30246,y:33269,varname:node_3708,prsc:2,rcp:True;n:type:ShaderForge.SFN_Add,id:6132,x:30712,y:33225,varname:node_6132,prsc:2|A-5497-Y,B-9667-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:9667,x:30526,y:33314,varname:node_9667,prsc:2|IN-3708-Y,IMIN-4515-OUT,IMAX-3708-Y,OMIN-4515-OUT,OMAX-9156-OUT;n:type:ShaderForge.SFN_Add,id:723,x:32748,y:32862,varname:node_723,prsc:2|A-7533-R,B-6358-OUT;n:type:ShaderForge.SFN_Tex2d,id:3158,x:32581,y:32446,ptovrint:False,ptlb:cor,ptin:_cor,varname:node_3158,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:eef76c08c4f033d4da89cba94e343141,ntxv:2,isnm:False|UVIN-7577-OUT;n:type:ShaderForge.SFN_TexCoord,id:3481,x:31650,y:32047,varname:node_3481,prsc:2,uv:0;n:type:ShaderForge.SFN_Divide,id:6224,x:31937,y:32228,varname:node_6224,prsc:2|A-3481-UVOUT,B-1545-OUT;n:type:ShaderForge.SFN_Slider,id:4340,x:31269,y:32354,ptovrint:False,ptlb:UvX,ptin:_UvX,varname:node_4340,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.4686649,max:0.9;n:type:ShaderForge.SFN_Slider,id:7992,x:31269,y:32474,ptovrint:False,ptlb:UvY,ptin:_UvY,varname:node_7992,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.4808586,max:0.9;n:type:ShaderForge.SFN_Append,id:4932,x:32038,y:32547,varname:node_4932,prsc:2|A-4340-OUT,B-7992-OUT;n:type:ShaderForge.SFN_Add,id:7577,x:32337,y:32337,varname:node_7577,prsc:2|A-6224-OUT,B-4932-OUT;n:type:ShaderForge.SFN_Vector1,id:1545,x:31637,y:32247,varname:node_1545,prsc:2,v1:2048;proporder:7533-6358-7947-9367-3158-4340-7992;pass:END;sub:END;*/

Shader "Shader Forge/GrassBlade_004" {
    Properties {
        _Mask ("Mask", 2D) = "white" {}
        _GrassAmont ("GrassAmont", Range(-0.4, 0.4)) = -0.4
        _WindAmont ("WindAmont", Range(0, 0.5)) = 0.1434368
        _WindSpeed ("WindSpeed", Range(0, 5)) = 2.256611
        _cor ("cor", 2D) = "black" {}
        _UvX ("UvX", Range(0.1, 0.9)) = 0.4686649
        _UvY ("UvY", Range(0.1, 0.9)) = 0.4808586
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="Grass"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float4 _TimeEditor;
            uniform sampler2D _Mask; uniform float4 _Mask_ST;
            uniform float _GrassAmont;
            uniform float _WindAmont;
            uniform float _WindSpeed;
            uniform sampler2D _cor; uniform float4 _cor_ST;
            uniform float _UvX;
            uniform float _UvY;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(_World2Object[0].xyz), length(_World2Object[1].xyz), length(_World2Object[2].xyz) );
                float4 node_7593 = _Time + _TimeEditor;
                float node_4515 = 0.0;
                float node_9156 = 1.0;
                float node_6885 = (node_4515 + ( (mul(_Object2World, v.vertex).g - objPos.g) * (node_9156 - node_4515) ) / ((objPos.g+(node_4515 + ( (recipObjScale.g - node_4515) * (node_9156 - node_4515) ) / (recipObjScale.g - node_4515))) - objPos.g));
                float node_6787 = sin(((node_7593.g*_WindSpeed)+node_6885));
                float node_5045 = (node_6787*_WindAmont*round(node_6885));
                v.vertex.xyz += (node_5045.r*float3(1,0,1));
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(_World2Object[0].xyz), length(_World2Object[1].xyz), length(_World2Object[2].xyz) );
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float4 _Mask_var = tex2D(_Mask,TRANSFORM_TEX(i.uv0, _Mask));
                float node_723 = (_Mask_var.r+_GrassAmont);
                clip(node_723 - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float node_1545 = 2048.0;
                float2 node_6224 = (i.uv0/node_1545);
                float2 node_4932 = float2(_UvX,_UvY);
                float2 node_7577 = (node_6224+node_4932);
                float4 _cor_var = tex2D(_cor,TRANSFORM_TEX(node_7577, _cor));
                float3 diffuseColor = _cor_var.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma exclude_renderers d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float4 _TimeEditor;
            uniform sampler2D _Mask; uniform float4 _Mask_ST;
            uniform float _GrassAmont;
            uniform float _WindAmont;
            uniform float _WindSpeed;
            uniform sampler2D _cor; uniform float4 _cor_ST;
            uniform float _UvX;
            uniform float _UvY;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(_World2Object[0].xyz), length(_World2Object[1].xyz), length(_World2Object[2].xyz) );
                float4 node_7593 = _Time + _TimeEditor;
                float node_4515 = 0.0;
                float node_9156 = 1.0;
                float node_6885 = (node_4515 + ( (mul(_Object2World, v.vertex).g - objPos.g) * (node_9156 - node_4515) ) / ((objPos.g+(node_4515 + ( (recipObjScale.g - node_4515) * (node_9156 - node_4515) ) / (recipObjScale.g - node_4515))) - objPos.g));
                float node_6787 = sin(((node_7593.g*_WindSpeed)+node_6885));
                float node_5045 = (node_6787*_WindAmont*round(node_6885));
                v.vertex.xyz += (node_5045.r*float3(1,0,1));
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(_World2Object[0].xyz), length(_World2Object[1].xyz), length(_World2Object[2].xyz) );
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float4 _Mask_var = tex2D(_Mask,TRANSFORM_TEX(i.uv0, _Mask));
                float node_723 = (_Mask_var.r+_GrassAmont);
                clip(node_723 - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float node_1545 = 2048.0;
                float2 node_6224 = (i.uv0/node_1545);
                float2 node_4932 = float2(_UvX,_UvY);
                float2 node_7577 = (node_6224+node_4932);
                float4 _cor_var = tex2D(_cor,TRANSFORM_TEX(node_7577, _cor));
                float3 diffuseColor = _cor_var.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma exclude_renderers d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _Mask; uniform float4 _Mask_ST;
            uniform float _GrassAmont;
            uniform float _WindAmont;
            uniform float _WindSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(_World2Object[0].xyz), length(_World2Object[1].xyz), length(_World2Object[2].xyz) );
                float4 node_7593 = _Time + _TimeEditor;
                float node_4515 = 0.0;
                float node_9156 = 1.0;
                float node_6885 = (node_4515 + ( (mul(_Object2World, v.vertex).g - objPos.g) * (node_9156 - node_4515) ) / ((objPos.g+(node_4515 + ( (recipObjScale.g - node_4515) * (node_9156 - node_4515) ) / (recipObjScale.g - node_4515))) - objPos.g));
                float node_6787 = sin(((node_7593.g*_WindSpeed)+node_6885));
                float node_5045 = (node_6787*_WindAmont*round(node_6885));
                v.vertex.xyz += (node_5045.r*float3(1,0,1));
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( _Object2World, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(_World2Object[0].xyz), length(_World2Object[1].xyz), length(_World2Object[2].xyz) );
/////// Vectors:
                float4 _Mask_var = tex2D(_Mask,TRANSFORM_TEX(i.uv0, _Mask));
                float node_723 = (_Mask_var.r+_GrassAmont);
                clip(node_723 - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
