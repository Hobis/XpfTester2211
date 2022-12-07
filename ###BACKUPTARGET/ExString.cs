        private static string _RemoveLeft(string target, string value)
        {
            if (string.IsNullOrWhiteSpace(target) ||
                string.IsNullOrWhiteSpace(value) ||
                (target.Length <= value.Length)) return target;

            int ti = target.IndexOf(value);
            if (ti == 0)
            {
                return target.Remove(ti, value.Length);
            }

            return target;
        }

        private static string _RemoveRight(string target, string value)
        {
            if (string.IsNullOrWhiteSpace(target) ||
                string.IsNullOrWhiteSpace(value) ||
                (target.Length <= value.Length)) return target;

            int ti = target.LastIndexOf(value);
            if (ti == (target.Length - value.Length))
            {
                return target.Remove(ti);
            }

            return target;
        }