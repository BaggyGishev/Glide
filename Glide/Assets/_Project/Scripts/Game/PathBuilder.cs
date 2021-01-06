﻿using UnityEditor;

namespace Gisha.Glide.Game
{
    public static class PathBuilder
    {
        // PATHES //
        public const string MainRelativePath = "_Project/Scenes/Main";
        public const string GalaxiesRelativePath = "_Project/Scenes/Galaxies";

        public const string LevelsDataRelativePath = "Assets/_Project/ScriptableObjects/LevelsData.asset";

        public static LevelsData LevelsDataAsset
        => AssetDatabase.LoadAssetAtPath(LevelsDataRelativePath, typeof(LevelsData)) as LevelsData;

        public static string GetSceneAssetPathFromCoords(LevelCoords coords)
        {
            var data = LevelsDataAsset;

            return $"{GalaxiesRelativePath}/" +
                $"{data.galaxies[coords.GalaxyID].galaxyName}/" +
                $"{data.galaxies[coords.GalaxyID].worldNames[coords.WorldID]}/" +
                $"Level {coords.LevelID + 1}";
        }

        public static string GetSceneAssetPathFromNames(string galaxyName, string worldName, int levelIndex)
        {
            return $"{GalaxiesRelativePath}/{galaxyName}/{worldName}/Level {levelIndex + 1}";
        }

        public static string GetPathToMainScene(string sceneName) 
            => $"{MainRelativePath}/{sceneName}";
    }
}