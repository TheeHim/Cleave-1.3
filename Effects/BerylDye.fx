sampler uImage0 : register(s0);
sampler uImage1 : register(s1);
float3 uColor;
float3 uSecondaryColor;
float uOpacity;
float uSaturation;
float uRotation;
float uTime;
float4 uSourceRect;
float2 uWorldPosition;
float uDirection;
float3 uLightSource;
float2 uImageSize0;
float2 uImageSize1;
    
float4 BerylDye(float4 sampleColor : COLOR0, float2 coords : TEXCOORD0) : COLOR0
{
    float4 color = tex2D(uImage0, coords);
    float wave1 = uSecondaryColor - frac(((coords.x / 3) + (((coords.y * uImageSize0.y - uSourceRect.y) / uSourceRect.w)) / 2) + uTime * 1.5f);
    float wave2 = uSecondaryColor - frac(-((coords.x / 1.5f) - (((coords.y * uImageSize0.y - uSourceRect.y) / uSourceRect.w)) / 3) + uTime * 1.5f);
    color.rgb *= uColor * (wave1 + 1) * (wave2 + 1) * 1.4f;
    return color * sampleColor;
}

    
technique Technique1
{
    pass BerylEffect
    {
        PixelShader = compile ps_2_0 BerylDye();
    }
}
