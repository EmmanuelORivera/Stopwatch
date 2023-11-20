using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
	public class Post
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public int Vote { get; private set; } = 0;

		public void VoteUp() { Vote += 1; }

		public void VoteDown() { Vote -= 1; }
	}
}
