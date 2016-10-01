// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34151,y:32657,varname:node_3138,prsc:2|emission-2960-OUT,clip-4377-OUT;n:type:ShaderForge.SFN_Tex2d,id:2175,x:31849,y:32976,ptovrint:False,ptlb:node_2175,ptin:_node_2175,varname:node_2175,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2fccfc37c56cb124ea3cfb3902c459e7,ntxv:0,isnm:False|UVIN-8575-OUT;n:type:ShaderForge.SFN_Slider,id:1539,x:30717,y:32932,ptovrint:False,ptlb:node_1539,ptin:_node_1539,varname:node_1539,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1048098,max:0.2;n:type:ShaderForge.SFN_Slider,id:6059,x:30705,y:33042,ptovrint:False,ptlb:node_6059,ptin:_node_6059,varname:node_6059,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01452986,max:0.2;n:type:ShaderForge.SFN_Time,id:2057,x:30966,y:33232,varname:node_2057,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:792,x:31150,y:32616,varname:node_792,prsc:2,uv:0;n:type:ShaderForge.SFN_Append,id:2781,x:31049,y:32959,varname:node_2781,prsc:2|A-1539-OUT,B-6059-OUT;n:type:ShaderForge.SFN_Multiply,id:2975,x:31309,y:33186,varname:node_2975,prsc:2|A-2781-OUT,B-2057-T;n:type:ShaderForge.SFN_Add,id:8575,x:31628,y:32976,varname:node_8575,prsc:2|A-792-UVOUT,B-2975-OUT;n:type:ShaderForge.SFN_Distance,id:7922,x:32007,y:33157,varname:node_7922,prsc:2|A-792-UVOUT,B-4077-OUT;n:type:ShaderForge.SFN_Vector2,id:4077,x:31707,y:33267,varname:node_4077,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_Slider,id:4458,x:31816,y:33597,ptovrint:False,ptlb:node_4458,ptin:_node_4458,varname:node_4458,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.264446,max:2;n:type:ShaderForge.SFN_Multiply,id:4574,x:32214,y:33214,varname:node_4574,prsc:2|A-7922-OUT,B-4458-OUT;n:type:ShaderForge.SFN_Add,id:4377,x:32491,y:33066,varname:node_4377,prsc:2|A-8399-OUT,B-3104-OUT;n:type:ShaderForge.SFN_Clamp01,id:3104,x:32392,y:33400,varname:node_3104,prsc:2|IN-4574-OUT;n:type:ShaderForge.SFN_Slider,id:7164,x:31816,y:33511,ptovrint:False,ptlb:node_7164,ptin:_node_7164,varname:node_7164,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.6069941,max:1;n:type:ShaderForge.SFN_Multiply,id:8399,x:32238,y:32947,varname:node_8399,prsc:2|A-2175-R,B-7164-OUT,C-2459-RGB;n:type:ShaderForge.SFN_Tex2d,id:2459,x:31732,y:32548,ptovrint:False,ptlb:node_2459,ptin:_node_2459,varname:node_2459,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-1468-OUT;n:type:ShaderForge.SFN_Multiply,id:6380,x:31314,y:32817,varname:node_6380,prsc:2|A-2057-T,B-2781-OUT,C-4940-OUT;n:type:ShaderForge.SFN_Add,id:1468,x:31522,y:32601,varname:node_1468,prsc:2|A-792-UVOUT,B-6380-OUT;n:type:ShaderForge.SFN_Vector1,id:4940,x:30898,y:32795,varname:node_4940,prsc:2,v1:0.8;n:type:ShaderForge.SFN_LightVector,id:9610,x:31742,y:32028,varname:node_9610,prsc:2;n:type:ShaderForge.SFN_Round,id:2757,x:32684,y:32844,varname:node_2757,prsc:2|IN-4377-OUT;n:type:ShaderForge.SFN_NormalVector,id:1472,x:31632,y:32300,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:1123,x:31995,y:32263,varname:node_1123,prsc:2,dt:0|A-9610-OUT,B-9865-OUT;n:type:ShaderForge.SFN_Add,id:7101,x:32187,y:32130,varname:node_7101,prsc:2|A-9610-OUT,B-1123-OUT,C-9610-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6567,x:32328,y:32130,varname:node_6567,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-7101-OUT;n:type:ShaderForge.SFN_Multiply,id:3312,x:32677,y:32554,varname:node_3312,prsc:2|A-630-OUT,B-6563-OUT;n:type:ShaderForge.SFN_OneMinus,id:6563,x:32461,y:32572,varname:node_6563,prsc:2|IN-2757-OUT;n:type:ShaderForge.SFN_Add,id:2240,x:33109,y:32472,varname:node_2240,prsc:2|A-5228-OUT,B-7667-OUT,C-6567-OUT,D-5112-RGB;n:type:ShaderForge.SFN_ConstantClamp,id:7667,x:32916,y:32544,varname:node_7667,prsc:2,min:-0.5,max:0.1|IN-3312-OUT;n:type:ShaderForge.SFN_LightColor,id:668,x:32515,y:31828,varname:node_668,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:1880,x:32515,y:32042,varname:node_1880,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5228,x:32803,y:32125,varname:node_5228,prsc:2|A-668-RGB,B-1880-OUT;n:type:ShaderForge.SFN_AmbientLight,id:5112,x:32697,y:32416,varname:node_5112,prsc:2;n:type:ShaderForge.SFN_OneMinus,id:9865,x:31821,y:32266,varname:node_9865,prsc:2|IN-1472-OUT;n:type:ShaderForge.SFN_Multiply,id:630,x:32461,y:32363,varname:node_630,prsc:2|A-6567-OUT,B-632-OUT;n:type:ShaderForge.SFN_Vector1,id:632,x:32262,y:32413,varname:node_632,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Multiply,id:3522,x:33343,y:32395,varname:node_3522,prsc:2|A-668-RGB,B-2240-OUT;n:type:ShaderForge.SFN_Multiply,id:9885,x:33623,y:31698,varname:node_9885,prsc:2|A-230-OUT,B-2757-OUT;n:type:ShaderForge.SFN_Multiply,id:2960,x:33556,y:32361,varname:node_2960,prsc:2|A-9885-OUT,B-3522-OUT;n:type:ShaderForge.SFN_Clamp01,id:989,x:32536,y:31559,varname:node_989,prsc:2|IN-6095-OUT;n:type:ShaderForge.SFN_OneMinus,id:6095,x:32247,y:31591,varname:node_6095,prsc:2|IN-9610-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9118,x:32776,y:31559,varname:node_9118,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-989-OUT;n:type:ShaderForge.SFN_ComponentMask,id:3568,x:32717,y:31328,varname:node_3568,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-5423-OUT;n:type:ShaderForge.SFN_ComponentMask,id:5058,x:32776,y:31702,varname:node_5058,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-8783-OUT;n:type:ShaderForge.SFN_Append,id:9709,x:33051,y:31292,varname:node_9709,prsc:2|A-6557-OUT,B-3568-OUT,C-3568-OUT;n:type:ShaderForge.SFN_Append,id:4407,x:33219,y:31671,varname:node_4407,prsc:2|A-6181-OUT,B-6181-OUT,C-5058-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:8783,x:32412,y:31687,varname:node_8783,prsc:2,min:-0.9,max:0|IN-655-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:5423,x:32536,y:31412,varname:node_5423,prsc:2,min:0,max:0.5|IN-6095-OUT;n:type:ShaderForge.SFN_Sign,id:6557,x:32880,y:31405,varname:node_6557,prsc:2|IN-3568-OUT;n:type:ShaderForge.SFN_Vector1,id:6181,x:32933,y:31615,varname:node_6181,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Clamp01,id:4759,x:33266,y:31302,varname:node_4759,prsc:2|IN-9709-OUT;n:type:ShaderForge.SFN_Blend,id:6836,x:33418,y:31489,varname:node_6836,prsc:2,blmd:10,clmp:False|SRC-4407-OUT,DST-4759-OUT;n:type:ShaderForge.SFN_Add,id:230,x:33591,y:31369,varname:node_230,prsc:2|A-9118-OUT,B-6836-OUT;n:type:ShaderForge.SFN_Multiply,id:655,x:32172,y:31817,varname:node_655,prsc:2|A-9610-OUT,B-8885-OUT;n:type:ShaderForge.SFN_Vector1,id:8885,x:32061,y:31979,varname:node_8885,prsc:2,v1:10;proporder:2175-1539-6059-4458-7164-2459;pass:END;sub:END;*/

Shader "Shader Forge/SkyClouds" {
    Properties {
        _node_2175 ("node_2175", 2D) = "white" {}
        _node_1539 ("node_1539", Range(0, 0.2)) = 0.1048098
        _node_6059 ("node_6059", Range(0, 0.2)) = 0.01452986
        _node_4458 ("node_4458", Range(0, 2)) = 1.264446
        _node_7164 ("node_7164", Range(0, 1)) = 0.6069941
        _node_2459 ("node_2459", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
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
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_2175; uniform float4 _node_2175_ST;
            uniform float _node_1539;
            uniform float _node_6059;
            uniform float _node_4458;
            uniform float _node_7164;
            uniform sampler2D _node_2459; uniform float4 _node_2459_ST;
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
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float2 node_2781 = float2(_node_1539,_node_6059);
                float4 node_2057 = _Time + _TimeEditor;
                float2 node_8575 = (i.uv0+(node_2781*node_2057.g));
                float4 _node_2175_var = tex2D(_node_2175,TRANSFORM_TEX(node_8575, _node_2175));
                float2 node_1468 = (i.uv0+(node_2057.g*node_2781*0.8));
                float4 _node_2459_var = tex2D(_node_2459,TRANSFORM_TEX(node_1468, _node_2459));
                float3 node_4377 = ((_node_2175_var.r*_node_7164*_node_2459_var.rgb)+saturate((distance(i.uv0,float2(0.5,0.5))*_node_4458)));
                clip(node_4377 - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float3 node_989 = saturate((1.0 - lightDirection));
                float node_9118 = node_989.r;
                float3 node_8783 = clamp((lightDirection*10.0),-0.9,0);
                float node_5058 = node_8783.g;
                float3 node_4407 = float3(0.5,0.5,node_5058);
                float node_3568 = clamp((1.0 - lightDirection),0,0.5).g;
                float3 node_9709 = float3(sign(node_3568),node_3568,node_3568);
                float3 node_4759 = saturate(node_9709);
                float3 node_6836 = ( node_4759 > 0.5 ? (1.0-(1.0-2.0*(node_4759-0.5))*(1.0-node_4407)) : (2.0*node_4759*node_4407) );
                float3 node_2757 = round(node_4377);
                float node_6567 = (lightDirection+dot(lightDirection,(1.0 - i.normalDir))+lightDirection).g;
                float3 emissive = (((node_9118+node_6836)*node_2757)*(_LightColor0.rgb*((_LightColor0.rgb*attenuation)+clamp(((node_6567*0.1)*(1.0 - node_2757)),-0.5,0.1)+node_6567+UNITY_LIGHTMODEL_AMBIENT.rgb)));
                float3 finalColor = emissive;
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
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_2175; uniform float4 _node_2175_ST;
            uniform float _node_1539;
            uniform float _node_6059;
            uniform float _node_4458;
            uniform float _node_7164;
            uniform sampler2D _node_2459; uniform float4 _node_2459_ST;
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
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float2 node_2781 = float2(_node_1539,_node_6059);
                float4 node_2057 = _Time + _TimeEditor;
                float2 node_8575 = (i.uv0+(node_2781*node_2057.g));
                float4 _node_2175_var = tex2D(_node_2175,TRANSFORM_TEX(node_8575, _node_2175));
                float2 node_1468 = (i.uv0+(node_2057.g*node_2781*0.8));
                float4 _node_2459_var = tex2D(_node_2459,TRANSFORM_TEX(node_1468, _node_2459));
                float3 node_4377 = ((_node_2175_var.r*_node_7164*_node_2459_var.rgb)+saturate((distance(i.uv0,float2(0.5,0.5))*_node_4458)));
                clip(node_4377 - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 finalColor = 0;
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
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_2175; uniform float4 _node_2175_ST;
            uniform float _node_1539;
            uniform float _node_6059;
            uniform float _node_4458;
            uniform float _node_7164;
            uniform sampler2D _node_2459; uniform float4 _node_2459_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 node_2781 = float2(_node_1539,_node_6059);
                float4 node_2057 = _Time + _TimeEditor;
                float2 node_8575 = (i.uv0+(node_2781*node_2057.g));
                float4 _node_2175_var = tex2D(_node_2175,TRANSFORM_TEX(node_8575, _node_2175));
                float2 node_1468 = (i.uv0+(node_2057.g*node_2781*0.8));
                float4 _node_2459_var = tex2D(_node_2459,TRANSFORM_TEX(node_1468, _node_2459));
                float3 node_4377 = ((_node_2175_var.r*_node_7164*_node_2459_var.rgb)+saturate((distance(i.uv0,float2(0.5,0.5))*_node_4458)));
                clip(node_4377 - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
