using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;
using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.Localization;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;

namespace Cleave.BGs.Skies
{
    public class CrylineSky : CustomSky
    {

		private struct LightPillar
		{
			public Vector2 Position;

			public float Depth;
		}

		private LightPillar[] _pillars;
		private struct Diamond
		{
			public Vector2 Position;

			public float Depth;

			public int TextureIndex;

			public float SinOffset;

			public float AlphaFrequency;

			public float AlphaAmplitude;
		}

		private readonly UnifiedRandom _random = new UnifiedRandom();

		private Texture2D _beamTexture;

		private Texture2D[] _diamondTextures;

		private bool _isActive;

		private Diamond[] _diamonds;

		private float _fadeOpacity;

		public override void OnLoad()
		{
			_beamTexture = TextureManager.Load("Images/Misc/NebulaSky/Beam");
			_diamondTextures = new Texture2D[3];
            for (int i = 0; i < _diamondTextures.Length; i++)
            {
                _diamondTextures[i] = ModContent.GetTexture("Cleave/Textures/CrylineSky/Diamond " + i);
            }
		}

		public override void Update(GameTime gameTime)
		{
			if (_isActive)
			{
				_fadeOpacity = Math.Min(1f, 0.01f + _fadeOpacity);
			}
			else
			{
				_fadeOpacity = Math.Max(0f, _fadeOpacity - 0.01f);
			}
		}

		public override Color OnTileColor(Color inColor)
		{
			return new Color(Vector4.Lerp(inColor.ToVector4(), Vector4.One, _fadeOpacity * 0.5f));
		}

		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			int num = -1;
			int num2 = 0;
			for (int i = 0; i < _diamonds.Length; i++)
			{
				float depth = _diamonds[i].Depth;
				if (num == -1 && depth < maxDepth)
				{
					num = i;
				}
				if (depth <= minDepth)
				{
					break;
				}
				num2 = i;
			}
			if (num == -1)
			{
				return;
			}
			float scale = Math.Min(1f, (Main.screenPosition.Y - 1000f) / 1000f);
			Vector2 value3 = Main.screenPosition + new Vector2(Main.screenWidth >> 1, Main.screenHeight >> 1);
			Rectangle rectangle = new Rectangle(-1000, -1000, 4000, 4000);
			for (int j = num; j < num2; j++)
			{
				Vector2 value4 = new Vector2(1f / _diamonds[j].Depth, 1.1f / _diamonds[j].Depth);
				Vector2 position = (_diamonds[j].Position - value3) * value4 + value3 - Main.screenPosition;
				if (rectangle.Contains((int)position.X, (int)position.Y))
				{
					float value5 = (float)Math.Sin(_diamonds[j].AlphaFrequency * Main.GlobalTime + _diamonds[j].SinOffset) * _diamonds[j].AlphaAmplitude + _diamonds[j].AlphaAmplitude;
					float num3 = (float)Math.Sin(_diamonds[j].AlphaFrequency * Main.GlobalTime * 5f + _diamonds[j].SinOffset) * 0.1f - 0.1f;
					value5 = MathHelper.Clamp(value5, 0f, 1f);
					Texture2D texture2D = _diamondTextures[_diamonds[j].TextureIndex];
					spriteBatch.Draw(texture2D, position, null, Color.White * scale * value5 * 0.8f * (1f - num3) * _fadeOpacity, MathHelper.ToRadians((Main.DiscoR - 112.5f) / 10), new Vector2(texture2D.Width >> 1, texture2D.Height >> 1), (value4.X * 0.5f + 0.5f) * (value5 * 0.3f + 0.7f), SpriteEffects.None, 0f);
				}
			}
			for (int i = 0; i < _pillars.Length; i++)
			{
				float depth = _pillars[i].Depth;
				if (num == -1 && depth < maxDepth)
				{
					num = i;
				}
				if (depth <= minDepth)
				{
					break;
				}
				num2 = i;
			}
			if (num == -1)
			{
				return;
			}
			for (int j = num; j < num2; j++)
			{
				Vector2 value42 = new Vector2(1f / _pillars[j].Depth, 0.9f / _pillars[j].Depth);
				Vector2 position2 = this._pillars[j].Position;
				position2 = (position2 - value3) * value42 + value3 - Main.screenPosition;
				if (rectangle.Contains((int)position2.X, (int)position2.Y))
				{
					float num32 = value42.X * 450f;
					spriteBatch.Draw(_beamTexture, position2, null, Color.White * 0.2f * scale * _fadeOpacity, 0f, Vector2.Zero, new Vector2(num32 / 70f, num32 / 45f), SpriteEffects.None, 0f);
				}
			}
		}

		public override float GetCloudAlpha()
		{
			return (1f - _fadeOpacity) * 0.3f + 0.7f;
		}

		public override void Activate(Vector2 position, params object[] args)
		{
			_fadeOpacity = 0.002f;
			_isActive = true;
			_pillars = new LightPillar[40];
			int num = 150;
			int num2 = 10;
			_diamonds = new Diamond[num * num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				float num4 = (float)i / (float)num;
				for (int j = 0; j < num2; j++)
				{
					float num5 = (float)j / (float)num2;
					_diamonds[num3].Position.X = num4 * (float)Main.maxTilesX * 16f;
					_diamonds[num3].Position.Y = num5 * ((float)Main.worldSurface * 16f + 2000f) - 1000f;
					_diamonds[num3].Depth = _random.NextFloat() * 8f + 1.5f;
					_diamonds[num3].TextureIndex = _random.Next(_diamondTextures.Length);
					_diamonds[num3].SinOffset = _random.NextFloat() * 6.28f;
					_diamonds[num3].AlphaAmplitude = _random.NextFloat() * 5f;
					_diamonds[num3].AlphaFrequency = _random.NextFloat() + 1f;
					num3++;
				}
			}
			Array.Sort(_diamonds, SortMethod);
			for (int q = 0; q < _pillars.Length; q++)
			{
				_pillars[q].Position.X = (float)q / _pillars.Length * (Main.maxTilesX * 16f + 20000f) + _random.NextFloat() * 40f - 20f - 20000f;
				_pillars[q].Position.Y = _random.NextFloat() * 200f - 2000f;
				_pillars[q].Depth = _random.NextFloat() * 8f + 7f;
			}
			Array.Sort(_pillars, SortMethod);
		}

		private int SortMethod(Diamond meteor1, Diamond meteor2)
		{
			return meteor2.Depth.CompareTo(meteor1.Depth);
		}
		private int SortMethod(LightPillar pillar1, LightPillar pillar2)
		{
			return pillar2.Depth.CompareTo(pillar1.Depth);
		}

		public override void Deactivate(params object[] args)
		{
			_isActive = false;
		}

		public override void Reset()
		{
			_isActive = false;
		}

		public override bool IsActive()
		{
			if (!_isActive)
			{
				return _fadeOpacity > 0.001f;
			}
			return _isActive;
		}
	}
}