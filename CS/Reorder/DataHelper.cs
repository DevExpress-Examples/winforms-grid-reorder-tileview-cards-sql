using System;
using System.Collections.Generic;

namespace Reorder {
    public class SampleObject {
        public string Text { get; set; }
        public int GroupId { get; set; }
        public int IndexInGroup { get; set; }
    }

    public class DataHelper {
        public static List<SampleObject> GetData() {
            var data = new List<SampleObject>();
            var rnd = new Random();
            for(int n = 0; n < 32; n++) {
                var record = new SampleObject();
                record.GroupId = rnd.Next(0, 5);
                record.IndexInGroup = n;
                record.Text = "Item " + n;
                data.Add(record);
            }
            return data;
        }
    }
}
