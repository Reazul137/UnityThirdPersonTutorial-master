// Shader created with Shader Forge v1.16 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.16;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,hqsc:True,nrmq:0,nrsp:0,vomd:0,spxs:False,tesm:0,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:4013,x:33280,y:36748,varname:node_4013,prsc:2|diff-4623-OUT;n:type:ShaderForge.SFN_NormalVector,id:3771,x:30845,y:37484,prsc:2,pt:True;n:type:ShaderForge.SFN_Tex2d,id:8939,x:30912,y:33959,ptovrint:False,ptlb:BodyColor,ptin:_BodyColor,varname:node_8939,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7991400c2e0b2a144ba514326539006f,ntxv:3,isnm:False|UVIN-7020-OUT;n:type:ShaderForge.SFN_Color,id:2833,x:30666,y:36943,ptovrint:False,ptlb:NeveColor,ptin:_NeveColor,varname:node_2833,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:7960,x:32542,y:36928,varname:node_7960,prsc:2|A-9739-OUT,B-2833-RGB,T-7504-OUT;n:type:ShaderForge.SFN_ComponentMask,id:7256,x:30936,y:37499,varname:node_7256,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-3771-OUT;n:type:ShaderForge.SFN_Multiply,id:5885,x:31368,y:37090,varname:node_5885,prsc:2|A-7996-RGB,B-8916-OUT;n:type:ShaderForge.SFN_Subtract,id:4435,x:31368,y:37207,varname:node_4435,prsc:2|A-7256-OUT,B-8439-OUT;n:type:ShaderForge.SFN_Tex2d,id:7996,x:30666,y:37128,ptovrint:False,ptlb:noise,ptin:_noise,varname:node_7996,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Vector1,id:8916,x:31171,y:37090,varname:node_8916,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Step,id:7504,x:31537,y:37139,varname:node_7504,prsc:2|A-5885-OUT,B-4435-OUT;n:type:ShaderForge.SFN_Vector1,id:832,x:30973,y:37334,varname:node_832,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:7992,x:30570,y:37329,ptovrint:False,ptlb:Temp,ptin:_Temp,varname:node_7992,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3176436,max:10;n:type:ShaderForge.SFN_Clamp,id:8439,x:31171,y:37290,varname:node_8439,prsc:2|IN-7992-OUT,MIN-832-OUT,MAX-6376-OUT;n:type:ShaderForge.SFN_Vector1,id:6376,x:30973,y:37384,varname:node_6376,prsc:2,v1:3;n:type:ShaderForge.SFN_TexCoord,id:4700,x:30211,y:33667,varname:node_4700,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:7020,x:30716,y:33892,varname:node_7020,prsc:2|A-2401-OUT,B-9650-OUT;n:type:ShaderForge.SFN_Append,id:9650,x:30528,y:34065,varname:node_9650,prsc:2|A-920-OUT,B-4267-OUT;n:type:ShaderForge.SFN_Slider,id:920,x:30108,y:34056,ptovrint:False,ptlb:uvVet,ptin:_uvVet,varname:node_920,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5131032,max:1;n:type:ShaderForge.SFN_Slider,id:4267,x:30108,y:34149,ptovrint:False,ptlb:uvHor,ptin:_uvHor,varname:node_4267,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5641026,max:1;n:type:ShaderForge.SFN_Vector1,id:7450,x:30232,y:33869,varname:node_7450,prsc:2,v1:100;n:type:ShaderForge.SFN_Divide,id:2401,x:30487,y:33835,varname:node_2401,prsc:2|A-4700-UVOUT,B-7450-OUT;n:type:ShaderForge.SFN_Color,id:3931,x:30429,y:35864,ptovrint:False,ptlb:NatColor,ptin:_NatColor,varname:_NeveColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2293469,c2:0.7426471,c3:0.296607,c4:1;n:type:ShaderForge.SFN_Subtract,id:7665,x:31746,y:36084,varname:node_7665,prsc:2|A-4774-OUT,B-6180-OUT;n:type:ShaderForge.SFN_Step,id:7587,x:31946,y:36023,varname:node_7587,prsc:2|A-3614-OUT,B-7665-OUT;n:type:ShaderForge.SFN_Vector1,id:4407,x:30781,y:36350,varname:node_4407,prsc:2,v1:7;n:type:ShaderForge.SFN_Slider,id:2473,x:30334,y:36208,ptovrint:False,ptlb:Nat,ptin:_Nat,varname:_Temp_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:8.556075,max:10;n:type:ShaderForge.SFN_Clamp,id:2626,x:31071,y:36232,varname:node_2626,prsc:2|IN-2473-OUT,MIN-4407-OUT,MAX-9240-OUT;n:type:ShaderForge.SFN_Vector1,id:9240,x:30781,y:36400,varname:node_9240,prsc:2,v1:10;n:type:ShaderForge.SFN_Lerp,id:9739,x:32240,y:35789,varname:node_9739,prsc:2|A-2560-OUT,B-3931-RGB,T-7587-OUT;n:type:ShaderForge.SFN_Subtract,id:589,x:31071,y:36399,varname:node_589,prsc:2|A-9240-OUT,B-4407-OUT;n:type:ShaderForge.SFN_Subtract,id:3738,x:31224,y:36232,varname:node_3738,prsc:2|A-2626-OUT,B-4407-OUT;n:type:ShaderForge.SFN_Divide,id:9284,x:31400,y:36232,varname:node_9284,prsc:2|A-3738-OUT,B-589-OUT;n:type:ShaderForge.SFN_OneMinus,id:6180,x:31580,y:36232,varname:node_6180,prsc:2|IN-9284-OUT;n:type:ShaderForge.SFN_Multiply,id:3614,x:31157,y:35957,varname:node_3614,prsc:2|A-6805-RGB,B-9065-OUT;n:type:ShaderForge.SFN_Vector1,id:9065,x:30936,y:35991,varname:node_9065,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:6805,x:30774,y:35951,ptovrint:False,ptlb:noise_copy,ptin:_noise_copy,varname:_noise_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:639a970fbe949f4449ae9f2e46b87133,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:9727,x:31198,y:35758,varname:node_9727,prsc:2|A-7256-OUT,B-9065-OUT;n:type:ShaderForge.SFN_Subtract,id:4774,x:31435,y:35758,varname:node_4774,prsc:2|A-744-OUT,B-9727-OUT;n:type:ShaderForge.SFN_Vector1,id:744,x:31266,y:35648,varname:node_744,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Color,id:2716,x:31296,y:34647,ptovrint:False,ptlb:CrackColor,ptin:_CrackColor,varname:_NeveColor_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7794118,c2:0.7794118,c3:0.7794118,c4:1;n:type:ShaderForge.SFN_Step,id:7749,x:31655,y:34862,varname:node_7749,prsc:2|A-3996-OUT,B-4880-OUT;n:type:ShaderForge.SFN_Slider,id:4366,x:30063,y:35050,ptovrint:False,ptlb:Age,ptin:_Age,varname:_Nat_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:9.523582,max:10;n:type:ShaderForge.SFN_Lerp,id:2560,x:32066,y:34709,varname:node_2560,prsc:2|A-8939-RGB,B-2669-OUT,T-7749-OUT;n:type:ShaderForge.SFN_Multiply,id:3996,x:31024,y:34808,varname:node_3996,prsc:2|A-7798-RGB,B-5611-OUT;n:type:ShaderForge.SFN_Vector1,id:5611,x:30803,y:34842,varname:node_5611,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:7798,x:30642,y:34802,ptovrint:False,ptlb:noise_copy_copy,ptin:_noise_copy_copy,varname:_noise_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e5910bf21b0d668408dca44adc1f3a42,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2669,x:31596,y:34631,varname:node_2669,prsc:2|A-8939-RGB,B-2716-RGB;n:type:ShaderForge.SFN_Vector1,id:3526,x:30187,y:35169,varname:node_3526,prsc:2,v1:5;n:type:ShaderForge.SFN_Clamp,id:1070,x:30477,y:35051,varname:node_1070,prsc:2|IN-4366-OUT,MIN-3526-OUT,MAX-5967-OUT;n:type:ShaderForge.SFN_Vector1,id:5967,x:30187,y:35219,varname:node_5967,prsc:2,v1:10;n:type:ShaderForge.SFN_Subtract,id:770,x:30630,y:35051,varname:node_770,prsc:2|A-1070-OUT,B-3526-OUT;n:type:ShaderForge.SFN_Divide,id:5167,x:30820,y:35051,varname:node_5167,prsc:2|A-770-OUT,B-5967-OUT;n:type:ShaderForge.SFN_Subtract,id:4880,x:31215,y:35014,varname:node_4880,prsc:2|A-5167-OUT,B-3423-OUT;n:type:ShaderForge.SFN_Vector1,id:3423,x:31028,y:35143,varname:node_3423,prsc:2,v1:0.01;n:type:ShaderForge.SFN_Fresnel,id:5059,x:32081,y:37090,varname:node_5059,prsc:2;n:type:ShaderForge.SFN_Vector1,id:2210,x:32103,y:37266,varname:node_2210,prsc:2,v1:3;n:type:ShaderForge.SFN_Power,id:9283,x:32496,y:37090,varname:node_9283,prsc:2|VAL-2940-OUT,EXP-2210-OUT;n:type:ShaderForge.SFN_Clamp01,id:2940,x:32326,y:37090,varname:node_2940,prsc:2|IN-5059-OUT;n:type:ShaderForge.SFN_Add,id:4623,x:32812,y:37001,varname:node_4623,prsc:2|A-7960-OUT,B-5592-OUT;n:type:ShaderForge.SFN_Multiply,id:5592,x:32678,y:37090,varname:node_5592,prsc:2|A-9283-OUT,B-2268-OUT,C-4283-RGB;n:type:ShaderForge.SFN_Slider,id:2268,x:32339,y:37318,ptovrint:False,ptlb:node_2268,ptin:_node_2268,varname:node_2268,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_AmbientLight,id:4283,x:32404,y:37465,varname:node_4283,prsc:2;proporder:8939-7996-7992-2833-2473-3931-4366-2716-920-4267-6805-7798-2268;pass:END;sub:END;*/

Shader "Shader Forge/NewShaderForgeTest_001_potes" {
    Properties {
        _BodyColor ("BodyColor", 2D) = "bump" {}
        _noise ("noise", 2D) = "white" {}
        _Temp ("Temp", Range(0, 10)) = 0.3176436
        _NeveColor ("NeveColor", Color) = (1,1,1,1)
        _Nat ("Nat", Range(0, 10)) = 8.556075
        _NatColor ("NatColor", Color) = (0.2293469,0.7426471,0.296607,1)
        _Age ("Age", Range(0, 10)) = 9.523582
        _CrackColor ("CrackColor", Color) = (0.7794118,0.7794118,0.7794118,1)
        _uvVet ("uvVet", Range(0, 1)) = 0.5131032
        _uvHor ("uvHor", Range(0, 1)) = 0.5641026
        _noise_copy ("noise_copy", 2D) = "white" {}
        _noise_copy_copy ("noise_copy_copy", 2D) = "white" {}
        _node_2268 ("node_2268", Range(0, 1)) = 1
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
            Cull Off
            
            
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
            uniform sampler2D _BodyColor; uniform float4 _BodyColor_ST;
            uniform float4 _NeveColor;
            uniform sampler2D _noise; uniform float4 _noise_ST;
            uniform float _Temp;
            uniform float _uvVet;
            uniform float _uvHor;
            uniform float4 _NatColor;
            uniform float _Nat;
            uniform sampler2D _noise_copy; uniform float4 _noise_copy_ST;
            uniform float4 _CrackColor;
            uniform float _Age;
            uniform sampler2D _noise_copy_copy; uniform float4 _noise_copy_copy_ST;
            uniform float _node_2268;
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
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
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
                float2 node_7020 = ((i.uv0/100.0)+float2(_uvVet,_uvHor));
                float4 _BodyColor_var = tex2D(_BodyColor,TRANSFORM_TEX(node_7020, _BodyColor));
                float4 _noise_copy_copy_var = tex2D(_noise_copy_copy,TRANSFORM_TEX(i.uv0, _noise_copy_copy));
                float node_3526 = 5.0;
                float node_5967 = 10.0;
                float4 _noise_copy_var = tex2D(_noise_copy,TRANSFORM_TEX(i.uv0, _noise_copy));
                float node_9065 = 0.5;
                float node_7256 = normalDirection.g;
                float node_4407 = 7.0;
                float node_9240 = 10.0;
                float4 _noise_var = tex2D(_noise,TRANSFORM_TEX(i.uv0, _noise));
                float3 diffuseColor = (lerp(lerp(lerp(_BodyColor_var.rgb,(_BodyColor_var.rgb*_CrackColor.rgb),step((_noise_copy_copy_var.rgb*0.5),(((clamp(_Age,node_3526,node_5967)-node_3526)/node_5967)-0.01))),_NatColor.rgb,step((_noise_copy_var.rgb*node_9065),((0.5-(node_7256*node_9065))-(1.0 - ((clamp(_Nat,node_4407,node_9240)-node_4407)/(node_9240-node_4407)))))),_NeveColor.rgb,step((_noise_var.rgb*0.5),(node_7256-clamp(_Temp,0.0,3.0))))+(pow(saturate((1.0-max(0,dot(normalDirection, viewDirection)))),3.0)*_node_2268*UNITY_LIGHTMODEL_AMBIENT.rgb));
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
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
            Cull Off
            
            
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
            uniform sampler2D _BodyColor; uniform float4 _BodyColor_ST;
            uniform float4 _NeveColor;
            uniform sampler2D _noise; uniform float4 _noise_ST;
            uniform float _Temp;
            uniform float _uvVet;
            uniform float _uvHor;
            uniform float4 _NatColor;
            uniform float _Nat;
            uniform sampler2D _noise_copy; uniform float4 _noise_copy_ST;
            uniform float4 _CrackColor;
            uniform float _Age;
            uniform sampler2D _noise_copy_copy; uniform float4 _noise_copy_copy_ST;
            uniform float _node_2268;
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
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                
                float nSign = sign( dot( viewDirection, i.normalDir ) ); // Reverse normal if this is a backface
                i.normalDir *= nSign;
                normalDirection *= nSign;
                
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float2 node_7020 = ((i.uv0/100.0)+float2(_uvVet,_uvHor));
                float4 _BodyColor_var = tex2D(_BodyColor,TRANSFORM_TEX(node_7020, _BodyColor));
                float4 _noise_copy_copy_var = tex2D(_noise_copy_copy,TRANSFORM_TEX(i.uv0, _noise_copy_copy));
                float node_3526 = 5.0;
                float node_5967 = 10.0;
                float4 _noise_copy_var = tex2D(_noise_copy,TRANSFORM_TEX(i.uv0, _noise_copy));
                float node_9065 = 0.5;
                float node_7256 = normalDirection.g;
                float node_4407 = 7.0;
                float node_9240 = 10.0;
                float4 _noise_var = tex2D(_noise,TRANSFORM_TEX(i.uv0, _noise));
                float3 diffuseColor = (lerp(lerp(lerp(_BodyColor_var.rgb,(_BodyColor_var.rgb*_CrackColor.rgb),step((_noise_copy_copy_var.rgb*0.5),(((clamp(_Age,node_3526,node_5967)-node_3526)/node_5967)-0.01))),_NatColor.rgb,step((_noise_copy_var.rgb*node_9065),((0.5-(node_7256*node_9065))-(1.0 - ((clamp(_Nat,node_4407,node_9240)-node_4407)/(node_9240-node_4407)))))),_NeveColor.rgb,step((_noise_var.rgb*0.5),(node_7256-clamp(_Temp,0.0,3.0))))+(pow(saturate((1.0-max(0,dot(normalDirection, viewDirection)))),3.0)*_node_2268*UNITY_LIGHTMODEL_AMBIENT.rgb));
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
