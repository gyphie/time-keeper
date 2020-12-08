using System;
using System.Drawing;

namespace TimeKeeper
{
	public class ColorAnimationLoop : ColorAnimation
	{
		public enum LoopType
		{
			ForwardBack,
			EndToStart
		}

		public ColorAnimationLoop(Color startColor, Color endColor, int steps, LoopType type) : base(startColor, endColor, steps)
		{
			this.Type = type;
		}

		private LoopType type = LoopType.ForwardBack;
		public LoopType Type
		{
			get { return this.type; }
			set
			{
				if (value == LoopType.EndToStart)
				{
					this.direction = 1;
				}

				this.type = value;
			}
		}
		private int direction = 1;

		public new Color GetNextColor()
		{
			if (this.CurrentStep == this.Steps && this.Type == LoopType.EndToStart)
			{
				this.CurrentStep = 0;
			}
			else if ((this.CurrentStep == this.Steps || this.CurrentStep == 1) && this.Type == LoopType.ForwardBack)
			{
				this.direction *= -1;
			}

			this.CurrentStep += this.direction;

			return this.GetColor();
		}
		public new Color GetPreviousColor()
		{
			if (this.CurrentStep == 1 && this.Type == LoopType.EndToStart)
			{
				this.CurrentStep = this.Steps + 1;
			}
			else if ((this.CurrentStep == this.Steps || this.CurrentStep == 1) && this.Type == LoopType.ForwardBack)
			{
				this.direction *= -1;
			}

			this.CurrentStep -= this.direction;

			return this.GetColor();
		}
	}
	
	public class ColorAnimation
	{
		private int steps = 1;
		public int Steps
		{
			get
			{
				return this.steps;
			}
			set
			{
				if (value < 1)
				{
					value = 1;
				}
				this.steps = value;

				if (this.currentStep > this.steps)
				{
					this.currentStep = this.steps;
				}
			}
		}
		private int currentStep = 1;
		public int CurrentStep
		{
			get
			{
				return currentStep;
			}
			set
			{
				if (value > steps)
				{
					this.currentStep = steps;
				}
				else if (value < 1)
				{
					this.currentStep = 1;
				}
				else
				{
					this.currentStep = value;
				}

			}
		}

		public Color CurrentColor
		{
			get
			{
				return this.GetColor();
			}
		}

		public Color StartColor { get; set; }
		public Color EndColor { get; set; }
		
		
		public ColorAnimation(Color startColor, Color endColor, int steps)
		{
			this.Steps = steps;
			if (this.Steps < 1) this.Steps = 1;
			this.CurrentStep = 0;
			this.StartColor = startColor;
			this.EndColor = endColor;
		}

		public Color GetNextColor()
		{
			++this.CurrentStep;
			return this.GetColor();
		}
		public Color GetPreviousColor()
		{
			--this.CurrentStep;
			return this.GetColor();
		}
		public Color GetCurrentColor()
		{
			return this.CurrentColor;
		}

		protected Color GetColor()
		{
			int r, g, b, a;

			r = this.StartColor.R + (int)Math.Floor(((float)this.EndColor.R - (float)this.StartColor.R) / (float)this.Steps * (float)this.CurrentStep);
			g = this.StartColor.G + (int)Math.Floor(((float)this.EndColor.G - (float)this.StartColor.G) / (float)this.Steps * (float)this.CurrentStep);
			b = this.StartColor.B + (int)Math.Floor(((float)this.EndColor.B - (float)this.StartColor.B) / (float)this.Steps * (float)this.CurrentStep);
			a = this.StartColor.A + (int)Math.Floor(((float)this.EndColor.A - (float)this.StartColor.A) / (float)this.Steps * (float)this.CurrentStep);

			return Color.FromArgb(a, r, g, b);
		}
	}
}
