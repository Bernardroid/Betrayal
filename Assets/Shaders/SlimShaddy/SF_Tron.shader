// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34632,y:32170,varname:node_3138,prsc:2|emission-1178-OUT,custl-9723-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:34113,y:32852,ptovrint:False,ptlb:Base Color,ptin:_BaseColor,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4558824,c2:0.9549695,c3:1,c4:1;n:type:ShaderForge.SFN_TexCoord,id:1092,x:32307,y:32784,varname:node_1092,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Slider,id:6071,x:31957,y:32625,ptovrint:False,ptlb:Width,ptin:_Width,varname:_node_6071,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3.418803,max:10;n:type:ShaderForge.SFN_Power,id:8397,x:32940,y:32698,varname:node_8397,prsc:2|VAL-8466-OUT,EXP-6366-OUT;n:type:ShaderForge.SFN_Exp,id:6366,x:32307,y:32623,varname:node_6366,prsc:2,et:0|IN-6071-OUT;n:type:ShaderForge.SFN_OneMinus,id:4404,x:32690,y:32823,varname:node_4404,prsc:2|IN-749-OUT;n:type:ShaderForge.SFN_Power,id:275,x:32940,y:32823,varname:node_275,prsc:2|VAL-4404-OUT,EXP-6366-OUT;n:type:ShaderForge.SFN_OneMinus,id:15,x:32666,y:33059,varname:node_15,prsc:2|IN-5433-OUT;n:type:ShaderForge.SFN_Power,id:1753,x:32940,y:33091,varname:node_1753,prsc:2|VAL-15-OUT,EXP-6366-OUT;n:type:ShaderForge.SFN_Power,id:1141,x:32940,y:32966,varname:node_1141,prsc:2|VAL-9480-OUT,EXP-6366-OUT;n:type:ShaderForge.SFN_Add,id:9238,x:33134,y:32764,varname:node_9238,prsc:2|A-8397-OUT,B-275-OUT;n:type:ShaderForge.SFN_Add,id:2005,x:33124,y:33030,varname:node_2005,prsc:2|A-1141-OUT,B-1753-OUT;n:type:ShaderForge.SFN_Blend,id:6089,x:33331,y:32968,varname:node_6089,prsc:2,blmd:6,clmp:True|SRC-9238-OUT,DST-2005-OUT;n:type:ShaderForge.SFN_Add,id:5845,x:33331,y:32723,varname:node_5845,prsc:2|A-9238-OUT,B-2005-OUT;n:type:ShaderForge.SFN_Multiply,id:4981,x:33884,y:32981,varname:node_4981,prsc:2|A-786-OUT,B-1571-OUT;n:type:ShaderForge.SFN_Slider,id:1571,x:33174,y:33182,ptovrint:False,ptlb:Strenght,ptin:_Strenght,varname:node_1571,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.6666667,max:3;n:type:ShaderForge.SFN_Multiply,id:9723,x:34113,y:32996,varname:node_9723,prsc:2|A-7241-RGB,B-4981-OUT;n:type:ShaderForge.SFN_Dot,id:8791,x:33039,y:32189,varname:node_8791,prsc:2,dt:1|A-3008-OUT,B-3722-OUT;n:type:ShaderForge.SFN_NormalVector,id:3008,x:32792,y:32106,prsc:2,pt:False;n:type:ShaderForge.SFN_ViewVector,id:3722,x:32792,y:32259,varname:node_3722,prsc:2;n:type:ShaderForge.SFN_Power,id:4130,x:33263,y:32483,varname:node_4130,prsc:2|VAL-4824-OUT,EXP-6366-OUT;n:type:ShaderForge.SFN_OneMinus,id:4824,x:33241,y:32189,varname:node_4824,prsc:2|IN-8791-OUT;n:type:ShaderForge.SFN_Multiply,id:1178,x:34113,y:32673,varname:node_1178,prsc:2|A-1071-RGB,B-4981-OUT;n:type:ShaderForge.SFN_Color,id:1071,x:34113,y:32534,ptovrint:False,ptlb:EmmisionColor,ptin:_EmmisionColor,varname:node_1071,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.09558821,c2:0.438641,c3:1,c4:1;n:type:ShaderForge.SFN_If,id:227,x:34009,y:32141,varname:node_227,prsc:2|A-3622-OUT,B-3545-OUT,GT-3622-OUT,EQ-3622-OUT,LT-9798-OUT;n:type:ShaderForge.SFN_Slider,id:3545,x:33367,y:31877,ptovrint:False,ptlb:Tolerance,ptin:_Tolerance,varname:node_3545,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2905983,max:1;n:type:ShaderForge.SFN_Vector1,id:9798,x:33653,y:32252,varname:node_9798,prsc:2,v1:0;n:type:ShaderForge.SFN_Posterize,id:3622,x:33653,y:32126,varname:node_3622,prsc:2|IN-4824-OUT,STPS-2729-OUT;n:type:ShaderForge.SFN_Add,id:3817,x:33533,y:32861,varname:node_3817,prsc:2|A-227-OUT,B-6089-OUT;n:type:ShaderForge.SFN_Clamp01,id:786,x:33707,y:32861,varname:node_786,prsc:2|IN-3817-OUT;n:type:ShaderForge.SFN_Slider,id:4269,x:33162,y:32017,ptovrint:False,ptlb:Steps,ptin:_Steps,varname:node_4269,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:10.68376,max:50;n:type:ShaderForge.SFN_Round,id:2729,x:33483,y:32017,varname:node_2729,prsc:2|IN-4269-OUT;n:type:ShaderForge.SFN_Vector1,id:5427,x:32274,y:32954,varname:node_5427,prsc:2,v1:0.008;n:type:ShaderForge.SFN_Subtract,id:749,x:32503,y:32863,varname:node_749,prsc:2|A-1092-U,B-5427-OUT;n:type:ShaderForge.SFN_Subtract,id:5433,x:32503,y:33059,varname:node_5433,prsc:2|A-1092-V,B-5427-OUT;n:type:ShaderForge.SFN_Add,id:8466,x:32515,y:32727,varname:node_8466,prsc:2|A-1092-U,B-5427-OUT;n:type:ShaderForge.SFN_Add,id:9480,x:32503,y:33193,varname:node_9480,prsc:2|A-1092-V,B-5427-OUT;proporder:7241-6071-1571-1071-3545-4269;pass:END;sub:END;*/

Shader "Uniat/GFX_04_Tron" {
    Properties {
        _BaseColor ("Base Color", Color) = (0.4558824,0.9549695,1,1)
        _Width ("Width", Range(0, 10)) = 3.418803
        _Strenght ("Strenght", Range(0, 3)) = 0.6666667
        _EmmisionColor ("EmmisionColor", Color) = (0.09558821,0.438641,1,1)
        _Tolerance ("Tolerance", Range(0, 1)) = 0.2905983
        _Steps ("Steps", Range(0, 50)) = 10.68376
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
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _BaseColor;
            uniform float _Width;
            uniform float _Strenght;
            uniform float4 _EmmisionColor;
            uniform float _Tolerance;
            uniform float _Steps;
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
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float node_4824 = (1.0 - max(0,dot(i.normalDir,viewDirection)));
                float node_2729 = round(_Steps);
                float node_3622 = floor(node_4824 * node_2729) / (node_2729 - 1);
                float node_227_if_leA = step(node_3622,_Tolerance);
                float node_227_if_leB = step(_Tolerance,node_3622);
                float node_5427 = 0.008;
                float node_6366 = exp(_Width);
                float node_9238 = (pow((i.uv0.r+node_5427),node_6366)+pow((1.0 - (i.uv0.r-node_5427)),node_6366));
                float node_2005 = (pow((i.uv0.g+node_5427),node_6366)+pow((1.0 - (i.uv0.g-node_5427)),node_6366));
                float node_4981 = (saturate((lerp((node_227_if_leA*0.0)+(node_227_if_leB*node_3622),node_3622,node_227_if_leA*node_227_if_leB)+saturate((1.0-(1.0-node_9238)*(1.0-node_2005)))))*_Strenght);
                float3 emissive = (_EmmisionColor.rgb*node_4981);
                float3 finalColor = emissive + (_BaseColor.rgb*node_4981);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
