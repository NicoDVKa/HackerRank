

namespace LeetCode.FindAllPeopleWithSecret
{
    public class FindAllPeopleWithSecret
    {
        public static IList<int> Execute(int n, int[][] meetings, int firstPerson)
        {
            ISet<int> peopleShareSecret = new SortedSet<int>() { 0, firstPerson };

            var meetingsWithTimeSorted = meetings.ToList();
            meetingsWithTimeSorted.Sort((x, y) => x[2].CompareTo(y[2]));

            List<List<int>> tmpMeetings = new List<List<int>>();
            var times = meetingsWithTimeSorted.Select(x => x[2]).ToHashSet().ToList();

            times.ForEach(x =>
            {
                var stuff = meetingsWithTimeSorted.Where(j => j[2] == x)
                                                .Select(y => new int[] { y[0], y[1] })
                                                .ToArray();

                for (int i = 0; i < stuff.Length; i++)
                {
                    var tmpList = stuff[i];
                    for (int j = i + 1; j < stuff.Length; j++)
                    {
                        var intersect = tmpList.Intersect(stuff[j]);

                        if (intersect.Count() > 0)
                        {
                            tmpList = tmpList.Concat(stuff[j]).ToArray();
                        }
                    }

                    tmpMeetings.Add(tmpList.ToList());
                }

            });


            tmpMeetings.ForEach(x =>
            {
                var intersectMeetings = peopleShareSecret.Intersect(x).ToList();
                if (intersectMeetings.Count > 0)
                {
                    x.ForEach(y =>
                    {
                        peopleShareSecret.Add(y);
                    });
                }
            });

            return peopleShareSecret.ToList();
        }

    }
}
