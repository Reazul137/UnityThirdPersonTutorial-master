// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:6856,x:35276,y:32366,varname:node_6856,prsc:2|diff-315-OUT,emission-1278-OUT;n:type:ShaderForge.SFN_NormalVector,id:4828,x:30155,y:31992,prsc:2,pt:False;n:type:ShaderForge.SFN_Abs,id:9557,x:30410,y:32002,varname:node_9557,prsc:2|IN-4828-OUT;n:type:ShaderForge.SFN_Dot,id:8391,x:30603,y:32081,varname:node_8391,prsc:2,dt:0|A-9557-OUT,B-6587-OUT;n:type:ShaderForge.SFN_ComponentMask,id:1087,x:30769,y:32066,varname:node_1087,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-8391-OUT;n:type:ShaderForge.SFN_Lerp,id:315,x:34048,y:32335,varname:node_315,prsc:2|A-5325-RGB,B-3311-OUT,T-6229-OUT;n:type:ShaderForge.SFN_Round,id:6229,x:31833,y:32177,varname:node_6229,prsc:2|IN-1652-OUT;n:type:ShaderForge.SFN_Multiply,id:8225,x:31471,y:32153,varname:node_8225,prsc:2|A-132-OUT,B-1087-OUT;n:type:ShaderForge.SFN_Clamp01,id:1652,x:31651,y:32177,varname:node_1652,prsc:2|IN-8225-OUT;n:type:ShaderForge.SFN_Multiply,id:5396,x:31417,y:31956,varname:node_5396,prsc:2|A-8094-OUT,B-1087-OUT;n:type:ShaderForge.SFN_Clamp01,id:9255,x:31576,y:31956,varname:node_9255,prsc:2|IN-5396-OUT;n:type:ShaderForge.SFN_Round,id:4686,x:31778,y:31956,varname:node_4686,prsc:2|IN-9255-OUT;n:type:ShaderForge.SFN_Lerp,id:4678,x:33306,y:32239,varname:node_4678,prsc:2|A-6791-RGB,B-8987-RGB,T-4686-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:8541,x:31309,y:33379,varname:node_8541,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6913,x:31928,y:33321,varname:node_6913,prsc:2|A-5847-OUT,B-8541-Y;n:type:ShaderForge.SFN_Lerp,id:3311,x:33724,y:32321,varname:node_3311,prsc:2|A-4678-OUT,B-6690-OUT,T-51-OUT;n:type:ShaderForge.SFN_Slider,id:132,x:30908,y:32355,ptovrint:False,ptlb:Rock_spread,ptin:_Rock_spread,varname:node_132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.1,max:1;n:type:ShaderForge.SFN_Slider,id:8094,x:30987,y:31781,ptovrint:False,ptlb:Grass_spread,ptin:_Grass_spread,varname:node_8094,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.5,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:5748,x:31086,y:33172,ptovrint:False,ptlb:Sand_higth,ptin:_Sand_higth,varname:node_5748,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_OneMinus,id:5160,x:32407,y:33214,varname:node_5160,prsc:2|IN-987-OUT;n:type:ShaderForge.SFN_Clamp01,id:987,x:32201,y:33206,varname:node_987,prsc:2|IN-6913-OUT;n:type:ShaderForge.SFN_Round,id:51,x:32535,y:32977,varname:node_51,prsc:2|IN-5160-OUT;n:type:ShaderForge.SFN_Fresnel,id:331,x:34385,y:33018,varname:node_331,prsc:2|NRM-3899-OUT,EXP-6140-OUT;n:type:ShaderForge.SFN_AmbientLight,id:3550,x:34215,y:32662,varname:node_3550,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1278,x:34487,y:32673,varname:node_1278,prsc:2|A-3550-RGB,B-2610-OUT;n:type:ShaderForge.SFN_Multiply,id:2610,x:34572,y:32987,varname:node_2610,prsc:2|A-4310-OUT,B-331-OUT;n:type:ShaderForge.SFN_Tex2d,id:6791,x:31973,y:32655,ptovrint:False,ptlb:Dirt,ptin:_Dirt,varname:node_6791,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7991400c2e0b2a144ba514326539006f,ntxv:0,isnm:False|UVIN-5972-OUT;n:type:ShaderForge.SFN_Vector3,id:6587,x:30163,y:32291,varname:node_6587,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Slider,id:2359,x:31421,y:32736,ptovrint:False,ptlb:Dirt_Sat,ptin:_Dirt_Sat,varname:node_2359,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.1,max:0.9;n:type:ShaderForge.SFN_Append,id:5972,x:31803,y:32655,varname:node_5972,prsc:2|A-9124-OUT,B-2359-OUT;n:type:ShaderForge.SFN_Slider,id:9124,x:31421,y:32630,ptovrint:False,ptlb:Dirt_hue,ptin:_Dirt_hue,varname:node_9124,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.1,max:0.9;n:type:ShaderForge.SFN_Slider,id:8962,x:32107,y:31923,ptovrint:False,ptlb:Grass_Hue,ptin:_Grass_Hue,varname:node_8962,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.3446008,max:1;n:type:ShaderForge.SFN_Slider,id:3745,x:32050,y:32023,ptovrint:False,ptlb:Grass_Sat,ptin:_Grass_Sat,varname:node_3745,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.4814096,max:1;n:type:ShaderForge.SFN_Append,id:4082,x:32447,y:31999,varname:node_4082,prsc:2|A-8962-OUT,B-3745-OUT;n:type:ShaderForge.SFN_Tex2d,id:8987,x:32610,y:32013,ptovrint:False,ptlb:Grass,ptin:_Grass,varname:node_8987,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:cb3091d98f2bdcc4da29018eecf3742d,ntxv:0,isnm:False|UVIN-4082-OUT;n:type:ShaderForge.SFN_Multiply,id:6690,x:32183,y:32767,varname:node_6690,prsc:2|A-6791-RGB,B-2332-OUT;n:type:ShaderForge.SFN_Vector1,id:4310,x:34021,y:32888,varname:node_4310,prsc:2,v1:2;n:type:ShaderForge.SFN_Tex2d,id:5325,x:32109,y:32376,ptovrint:False,ptlb:Rock,ptin:_Rock,varname:node_5325,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7991400c2e0b2a144ba514326539006f,ntxv:0,isnm:False|UVIN-5475-OUT;n:type:ShaderForge.SFN_Slider,id:2332,x:31434,y:32872,ptovrint:False,ptlb:Dirt_sand_dif,ptin:_Dirt_sand_dif,varname:node_2332,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:2,max:2;n:type:ShaderForge.SFN_Slider,id:2763,x:31535,y:32355,ptovrint:False,ptlb:Rock_hue,ptin:_Rock_hue,varname:node_2763,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.1,max:0.9;n:type:ShaderForge.SFN_Slider,id:2647,x:31508,y:32471,ptovrint:False,ptlb:Rock_Sat,ptin:_Rock_Sat,varname:node_2647,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.1,max:0.9;n:type:ShaderForge.SFN_Append,id:5475,x:31906,y:32365,varname:node_5475,prsc:2|A-2763-OUT,B-2647-OUT;n:type:ShaderForge.SFN_ConstantLerp,id:5847,x:31542,y:33116,varname:node_5847,prsc:2,a:0.2,b:0|IN-5748-OUT;n:type:ShaderForge.SFN_Vector1,id:6140,x:34021,y:33018,varname:node_6140,prsc:2,v1:10;n:type:ShaderForge.SFN_NormalVector,id:3899,x:33954,y:33118,prsc:2,pt:False;proporder:132-2763-2647-5325-8962-3745-8094-8987-9124-2359-5748-2332-6791;pass:END;sub:END;*/

Shader "Shader Forge/NewShaderForgeTest_002_Terain" {
    Properties {
        _Rock_spread ("Rock_spread", Range(0.1, 1)) = 0.1
        _Rock_hue ("Rock_hue", Range(0.1, 0.9)) = 0.1
        _Rock_Sat ("Rock_Sat", Range(0.1, 0.9)) = 0.1
        _Rock ("Rock", 2D) = "white" {}
        _Grass_Hue ("Grass_Hue", Range(0.1, 1)) = 0.3446008
        _Grass_Sat ("Grass_Sat", Range(0.1, 1)) = 0.4814096
        _Grass_spread ("Grass_spread", Range(0.5, 1)) = 1
        _Grass ("Grass", 2D) = "white" {}
        _Dirt_hue ("Dirt_hue", Range(0.1, 0.9)) = 0.1
        _Dirt_Sat ("Dirt_Sat", Range(0.1, 0.9)) = 0.1
        _Sand_higth ("Sand_higth", Range(0, 1)) = 0
        _Dirt_sand_dif ("Dirt_sand_dif", Range(1, 2)) = 2
        _Dirt ("Dirt", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float _Rock_spread;
            uniform float _Grass_spread;
            uniform float _Sand_higth;
            uniform sampler2D _Dirt; uniform float4 _Dirt_ST;
            uniform float _Dirt_Sat;
            uniform float _Dirt_hue;
            uniform float _Grass_Hue;
            uniform float _Grass_Sat;
            uniform sampler2D _Grass; uniform float4 _Grass_ST;
            uniform sampler2D _Rock; uniform float4 _Rock_ST;
            uniform float _Dirt_sand_dif;
            uniform float _Rock_hue;
            uniform float _Rock_Sat;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
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
                float2 node_5475 = float2(_Rock_hue,_Rock_Sat);
                float4 _Rock_var = tex2D(_Rock,TRANSFORM_TEX(node_5475, _Rock));
                float2 node_5972 = float2(_Dirt_hue,_Dirt_Sat);
                float4 _Dirt_var = tex2D(_Dirt,TRANSFORM_TEX(node_5972, _Dirt));
                float2 node_4082 = float2(_Grass_Hue,_Grass_Sat);
                float4 _Grass_var = tex2D(_Grass,TRANSFORM_TEX(node_4082, _Grass));
                float node_1087 = dot(abs(i.normalDir),float3(0,1,0)).r;
                float3 diffuseColor = lerp(_Rock_var.rgb,lerp(lerp(_Dirt_var.rgb,_Grass_var.rgb,round(saturate((_Grass_spread*node_1087)))),(_Dirt_var.rgb*_Dirt_sand_dif),round((1.0 - saturate((lerp(0.2,0,_Sand_higth)*i.posWorld.g))))),round(saturate((_Rock_spread*node_1087))));
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = (UNITY_LIGHTMODEL_AMBIENT.rgb*(2.0*pow(1.0-max(0,dot(i.normalDir, viewDirection)),10.0)));
/// Final Color:
                float3 finalColor = diffuse + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float _Rock_spread;
            uniform float _Grass_spread;
            uniform float _Sand_higth;
            uniform sampler2D _Dirt; uniform float4 _Dirt_ST;
            uniform float _Dirt_Sat;
            uniform float _Dirt_hue;
            uniform float _Grass_Hue;
            uniform float _Grass_Sat;
            uniform sampler2D _Grass; uniform float4 _Grass_ST;
            uniform sampler2D _Rock; uniform float4 _Rock_ST;
            uniform float _Dirt_sand_dif;
            uniform float _Rock_hue;
            uniform float _Rock_Sat;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float2 node_5475 = float2(_Rock_hue,_Rock_Sat);
                float4 _Rock_var = tex2D(_Rock,TRANSFORM_TEX(node_5475, _Rock));
                float2 node_5972 = float2(_Dirt_hue,_Dirt_Sat);
                float4 _Dirt_var = tex2D(_Dirt,TRANSFORM_TEX(node_5972, _Dirt));
                float2 node_4082 = float2(_Grass_Hue,_Grass_Sat);
                float4 _Grass_var = tex2D(_Grass,TRANSFORM_TEX(node_4082, _Grass));
                float node_1087 = dot(abs(i.normalDir),float3(0,1,0)).r;
                float3 diffuseColor = lerp(_Rock_var.rgb,lerp(lerp(_Dirt_var.rgb,_Grass_var.rgb,round(saturate((_Grass_spread*node_1087)))),(_Dirt_var.rgb*_Dirt_sand_dif),round((1.0 - saturate((lerp(0.2,0,_Sand_higth)*i.posWorld.g))))),round(saturate((_Rock_spread*node_1087))));
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
