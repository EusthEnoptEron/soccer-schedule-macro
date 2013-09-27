using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SoccerScheduler.Elements
{
    [Serializable]
    class Category : Element
    {


        readonly TeamList Teams;

        public Category()
        {
            Teams = new TeamList(this);
        }
        public PlayDay DefaultDay { get; set; }
        public string Name { get; set; }


        [Serializable]
        class TeamList : TwoWayList<Team>
        {
            private readonly Category Category;
            internal TeamList(Category category)
            {
                Category = category;
            }

            protected override void Link(Team item)
            {
                // Check for previous implementation
                if (item.Category != null)
                    item.Category.Teams.Unlink(item);

                item.Category = Category;
            }

            protected override void Unlink(Team item)
            {
                item.Category = null;
            }
        }
    }

}
