using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuliva.com.AnimalKingdom.EnumTypes
{
    public class EnumTypes
    {
        public enum HumanGenderTYPE
        {
            MALE,
            FEMALE
        }

        public enum DuckTYPE
        {
            UNKNOWN,
            DABBLING,
            DIVING,
            EIDER,
            GOLDENEYE,
            MERGANSER,
            PERCHING,
            SCOTER,
            SEA,
            STIFFTAIL,
            TEAL,
            WHISTLING,
            DOMESTIC
        }

        public enum GenderTYPE
        {
            UNKNOWN,
            MALE,
            FEMALE,
            HERMAPHRODITE
        }

        public enum BirdANATOMY
        {
            UNKNOWN,
            SKELETAL,
            EXCRETORY,
            RESPIRATORY,
            CIRCULATORY,
            NERVOUS_SYSTEM,
            DEFENCE_COMBAT,
            INTRASPECIFIC_COMBAT,
            CHROMOSOMES,
            FEATHERS,
            PLUMAGE,
            SCALES,
            FLIGHT
        }

        public enum EagleGROUPS
        {
            UNKNOWN,
            FISH,
            BOOTED,
            SNAKE,
            HARPY
        }

        public enum FishWaterTYPE
        {
            FRESH_WATER,
            SEA_WATER
        }
        public enum MammalTYPE
        {
            MONOTREME,
            MARSUPIAL,
            PLACENTAL
        }

        public enum BrainSIZE
        {
            UNKNOWN,
            VERY_SMALL,
            SMALL,
            MEDIUM,
            LARGE,
            HUMAN_LARGE,
            STEPHEN_HAWKING_LARGE
        }

        public enum PrimateLOCOMOTION
        {
            UNKNOWN,
            BRACHIATION,
            BIPEDLISM,
            LEAPING,
            QUADREPEDALISM,
            CLIMBING,
            KNUCKLE_WALKING,
            SWINGING
        }

        public enum SharkANATOMY
        {
            UNKNOWN,
            TEETH,
            SKELETON,
            JAW,
            FINS,
            DERMAL_DENTICLES,
            TAILS,
            GILLS
        }

        public enum TroutHabitatLOCATION
        {
            UNKNOWN,
            NORTH_AMERICA,
            NORTHERN_ASIA,
            EUROPE,
            AUSTRALIA,
            NEW_ZEALAND
        }
    }
}
