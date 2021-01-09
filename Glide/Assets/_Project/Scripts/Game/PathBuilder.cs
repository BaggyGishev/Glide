﻿using UnityEditor;

namespace Gisha.Glide.Game
{
    public static class PathBuilder
    {
        public const string MainRelativePath = "_Project/Scenes/Main";
        public const string GalaxiesRelativePath = "_Project/Scenes/Galaxies";
        public const string LevelsMapRelativePath = "Assets/_Project/ScriptableObjects/LevelsMap.asset";

        public static LevelsMap LevelsMapAsset => AssetDatabase.LoadAssetAtPath(LevelsMapRelativePath, typeof(LevelsMap)) as LevelsMap;

        public static string GetScenePathFromCoords(LevelCoords coords)
        {
            var map = LevelsMapAsset;

            return $"{GalaxiesRelativePath}/" +
                $"{map.galaxies[coords.GalaxyID].galaxyName}/" +
                $"{map.galaxies[coords.GalaxyID].worldNames[coords.WorldID]}/" +
                $"Level {coords.LevelID + 1}";
        }

        public static string GetScenePathFromNames(string galaxyName, string worldName, int levelIndex) 
            => $"{GalaxiesRelativePath}/{galaxyName}/{worldName}/Level {levelIndex + 1}";

        public static string GetPathToMainScene(string sceneName) 
            => $"{MainRelativePath}/{sceneName}";
    }
}