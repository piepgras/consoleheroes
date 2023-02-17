using ConsoleHeroes.Game.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroes.Game.Modifiers
{
    internal class Experience
    {
        private const int _levelExperienceMultiplier = 2;
        private int _level = 1;
        private int _currentExperience = 0;
        private int _experienceNeededToLevel = 100;

        public int Level { get { return _level; } set { _level = value; } }
        public int CurrentExperience { get { return _currentExperience; } }
        public int ExperienceNeededToLevel { get { return _experienceNeededToLevel; } }

        public bool gainExperience(int experienceGained)
        {
            _currentExperience += experienceGained;

            if (_currentExperience >= _experienceNeededToLevel)
            {
                _level++;
                _experienceNeededToLevel = _experienceNeededToLevel * _levelExperienceMultiplier;
                Narrator.LevelUp(_level, _currentExperience, _experienceNeededToLevel);
                return true;
            }
            else
            {
                Narrator.ExperienceGain(experienceGained, _currentExperience, _experienceNeededToLevel);
                return false;
            }
        }
    }
}
