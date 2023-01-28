using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivis_zrdadobit_dalageba
{
	class Car : Comparable
	{
		public string Model { get; set; }
		public int Speed { get; set; }

		public override int CompareTo(object obj)
		{
			if (this.Speed > (obj as Car).Speed)
			{
				return 1;
			}
			else if (this.Speed < (obj as Car).Speed)
			{
				return -1;
			}
			else
			{
				if (this.Model.Length > (obj as Car).Model.Length)
				{
					return 1;
				}
				else if (this.Model.Length < (obj as Car).Model.Length)
				{
					return -1;
				}
			}

			return 0;
		}

		public override string ToString()
		{
			return $"{Model}, {Speed}";
		}
	}
}
