using System;

namespace Inspect.Framework.Logging
{
    public class Level : IComparable
    {
        public static readonly Level All = new Level(int.MinValue, "ALL");

        public static readonly Level Debug = new Level(20000, "DEBUG");

        public static readonly Level Error = new Level(50000, "ERROR");

        public static readonly Level Fatal = new Level(60000, "FATAL");

        public static readonly Level Info = new Level(30000, "INFO");

        public static readonly Level Off = new Level(int.MaxValue, "OFF");

        public static readonly Level Trace = new Level(10000, "TRACE");

        public static readonly Level Warn = new Level(40000, "WARN");

        private readonly string mLevelName;

        private readonly int mLevelValue;

        public Level(int level, string levelName)
        {
            this.mLevelValue = level;
            this.mLevelName = levelName ?? throw new ArgumentNullException(nameof(levelName));
        }

        public string Name
        {
            get
            {
                return this.mLevelName;
            }
        }

        public int Value
        {
            get
            {
                return this.mLevelValue;
            }
        }

        public static int Compare(Level left, Level right)
        {
            // Reference equals
            if ((object)left == (object)right)
            {
                return 0;
            }

            if (left == null && right == null)
            {
                return 0;
            }
            if (left == null)
            {
                return -1;
            }
            if (right == null)
            {
                return 1;
            }

            return left.mLevelValue.CompareTo(right.mLevelValue);
        }

        public static bool operator !=(Level left, Level right)
        {
            return !(left == right);
        }

        public static bool operator <(Level left, Level right)
        {
            return left.mLevelValue < right.mLevelValue;
        }

        public static bool operator <=(Level left, Level right)
        {
            return left.mLevelValue <= right.mLevelValue;
        }

        public static bool operator ==(Level left, Level right)
        {
            if (((object)left) != null && ((object)right) != null)
            {
                return left.mLevelValue == right.mLevelValue;
            }
            else
            {
                return ((object)left) == ((object)right);
            }
        }

        public static bool operator >(Level left, Level right)
        {
            return left.mLevelValue > right.mLevelValue;
        }

        public static bool operator >=(Level left, Level right)
        {
            return left.mLevelValue >= right.mLevelValue;
        }

        public int CompareTo(object obj)
        {
            Level target = obj as Level;
            if (target != null)
            {
                return Compare(this, target);
            }
            throw new ArgumentException("Object is not an instance of Level", "obj");
        }

        public override bool Equals(object obj)
        {
            Level otherLevel = obj as Level;
            if (otherLevel != null)
            {
                return mLevelValue == otherLevel.mLevelValue;
            }
            else
            {
                return base.Equals(obj);
            }
        }

        public override int GetHashCode()
        {
            return mLevelValue;
        }

        public override string ToString()
        {
            return this.mLevelName;
        }
    }
}