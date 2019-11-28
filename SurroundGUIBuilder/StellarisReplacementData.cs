using System.Collections.Generic;

namespace SurroundGUIBuilder
{
    public static class StellarisReplacementData
    {
        public static string modPath = @"C:\Users\james\Saved Games\Paradox Interactive\Stellaris\mod\surround-gui\interface\";

        public static ReplacementConfiguration ReplacementConfiguration = new ReplacementConfiguration()
        {
            bevelSize = 48,
            singleMonitorWidth = 1920
        };

        public static IEnumerable<Template> Templates = new List<Template>
        {
            new Template()
            {
                Filename = "frontend.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "game_logo",
                        BaseValue = 140,
                        ScreenLengths = 1,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "select_empire_design.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "select_empire_design_view",
                        BaseValue = 0,
                        ScreenLengths = 1,
                        IncludeBevel = true
                    },
                    new Replacement()
                    {
                        Name = "select_empire_design_view_width",
                        BaseValue = 0,
                        ScreenLengths = 1,
                        IncludeBevel = false
                    }
                }
            },
            new Template()
            {
                Filename = "main.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "maingui_flag",
                        BaseValue = 0,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    },
                    new Replacement()
                    {
                        Name = "maingui",
                        BaseValue = 0,
                        ScreenLengths = 1,
                        IncludeBevel = true
                    },
                    new Replacement()
                    {
                        Name = "maingui_width",
                        BaseValue = 0,
                        ScreenLengths = 1,
                        IncludeBevel = false
                    },
                    new Replacement()
                    {
                        Name = "maingui_lower_topbar",
                        BaseValue = 170,
                        ScreenLengths = 1,
                        IncludeBevel = true
                    },
                    new Replacement()
                    {
                        Name = "maingui_left_bar_buttons",
                        BaseValue = -225,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "console.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "console_wnd",
                        BaseValue = 30,
                        ScreenLengths = 1,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "main_bottom.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "control_groups",
                        BaseValue = 4,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    },
                    new Replacement()
                    {
                        Name = "mapmodes",
                        BaseValue = 277,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    },
                    new Replacement()
                    {
                        Name = "toolbar",
                        BaseValue = 379,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "advisor_window.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "advisor_window",
                        BaseValue = -110,
                        ScreenLengths = 1,
                        IncludeBevel = false
                    },
                    new Replacement()
                    {
                        Name = "advisor_tutorial_window",
                        BaseValue = -420,
                        ScreenLengths = 1,
                        IncludeBevel = false
                    }
                }
            },
            new Template()
            {
                Filename = "galaxy_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "galaxy_view",
                        BaseValue = -35,
                        ScreenLengths = 1,
                        IncludeBevel = false
                    }
                }
            },
            new Template()
            {
                Filename = "outliner.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "outliner_toggle_window",
                        BaseValue = -65,
                        ScreenLengths = 1,
                        IncludeBevel = false
                    },
                    new Replacement()
                    {
                        Name = "outliner_base_window",
                        BaseValue = -260,
                        ScreenLengths = 1,
                        IncludeBevel = false
                    },
                    new Replacement()
                    {
                        Name = "outliner_options_window",
                        BaseValue = -690,
                        ScreenLengths = 1,
                        IncludeBevel = false
                    }
                }
            },
            new Template()
            {
                Filename = "situation_log.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "situation_log",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "market_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "market_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "empire_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "empire_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "expansion_planner_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "expansion_planner_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "policies_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "policies_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "edicts_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "policies_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "topbar_traditions_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "traditions_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "ship_designer.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "ship_designer",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "fleet_manager_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "fleet_manager_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "technology_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "technology_view_window",
                        BaseValue = 30,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "topbar_factions_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "topbar_factions_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "claims_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "claims_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "topbar_species_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "topbar_species_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "topbar_leaders_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "topbar_leaders_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "government_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "government_view",
                        BaseValue = 30,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "fleet_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "fleet_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "starbase_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "starbase_view",
                        BaseValue = 35,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "planet_view.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "planet_view",
                        BaseValue = 300,
                        ScreenLengths = 2,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "alerts.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "alerticon_startposition",
                        BaseValue = 200,
                        ScreenLengths = 1,
                        IncludeBevel = true
                    }
                }
            },
            new Template()
            {
                Filename = "customize_species.gui",
                Replacements = new List<Replacement>()
                {
                    new Replacement()
                    {
                        Name = "menu",
                        BaseValue = 0,
                        ScreenLengths = 1,
                        IncludeBevel = true
                    }
                }
            }
        };
    }
}