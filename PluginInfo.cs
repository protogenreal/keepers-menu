/*
 * Keeper's Menu  PluginInfo.cs
 * A mod menu for Gorilla Tag with over 1000+ mods
 *
 * Copyright (C) 2026  Keepers Software
 * https://github.com/protogenreal/keepers-menu
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

namespace kMenu
{
    public class PluginInfo
    {
        public const string GUID = "org.keeper.gorillatag.kmenu";
        public const string Name = "Keeper's Menu";
        public const string Description = "Created by Keeper with love <3";
        public const string BuildTimestamp = "2026-07-30T00:49:51Z";
        public const string Version = "1.0.0";

        public const string BaseDirectory = "KeepersMenu";
        public const string ClientResourcePath = "kMenu.Resources.Client";
        public const string ServerResourcePath = "https://raw.githubusercontent.com/protogenreal/keepers-menu/master/Resources/Server";
        public const string ServerAPI = "https://iidk.online"; // Server now closed source due to bad actors :( For any questions, please make an issue on the GitHub repository.
        
        public const string Logo = @"Keeper's Menu Yes";

#if DEBUG
        public static bool BetaBuild = true;
#else
        public static bool BetaBuild = false;
#endif
    }
}
