using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace PuzzleScript
{

    public class Puzzle : MonoBehaviour
    {
        [SerializeField] private Transform emptySpace = null;
        private Camera m_Camera;
        [SerializeField] private TileScript[] tiles;
        private int emptySpaceIndex = 15;


        void Start()
        {
            m_Camera = Camera.main;
            Shuffle();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = m_Camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
                if (hit)
                {
                    Debug.Log(hit.transform.name);
                    if (Vector2.Distance(emptySpace.position, hit.transform.position) < 4.0)
                    {
                        Vector2 lastEmptySpacePos = emptySpace.position;
                        TileScript thisTile = hit.transform.GetComponent<TileScript>();
                        emptySpace.position = thisTile.TargetPos;
                        thisTile.TargetPos = lastEmptySpacePos;
                        int tileIndex = findIndex(thisTile);
                        tiles[emptySpaceIndex] = tiles[tileIndex];
                        tiles[tileIndex] = null;
                        emptySpaceIndex = tileIndex;
                    }
                }
            }
            int correctTiles = 0;
            foreach (var a in tiles)
            {
                if (a != null)
                {

                    if (a.inRightPlace)
                    {
                        correctTiles++;
                    }
                }
            }
            // Add victory condition.
            // Close puzzle and do something ???
            if (correctTiles == tiles.Length - 1)
            {
                
            }
        }
        public void Shuffle()
        {
            if (emptySpaceIndex != 15)
            {
                var TileOn15LastPos = tiles[15].TargetPos;
                tiles[15].TargetPos = emptySpace.position;
                emptySpace.position = TileOn15LastPos;
                tiles[emptySpaceIndex] = tiles[15];
                tiles[15] = null;
                emptySpaceIndex = 15;
            }
            int inversion;
            do
            {
                for (int i = 0; i <= 14; i++)
                {
                    if (tiles[i] != null)
                    {
                        var LastPos = tiles[i].TargetPos;
                        int randomIndex = Random.Range(0, 14);
                        tiles[i].TargetPos = tiles[randomIndex].TargetPos;
                        tiles[randomIndex].TargetPos = LastPos;
                        var tile = tiles[i];
                        tiles[i] = tiles[randomIndex];
                        tiles[randomIndex] = tile;
                    }
                }
                inversion = GetInversions();
            } while (inversion % 2 != 0);

        }
        public int findIndex(TileScript ts)
        {
            for (int i = 0; i < tiles.Length; i++)
            {
                if (tiles[i] != null)
                {
                    if (tiles[i] == ts)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        int GetInversions()
        {
            int inversionsSum = 0;
            for (int i = 0; i < tiles.Length; i++)
            {
                int thisTileInvertion = 0;
                for (int j = i; j < tiles.Length; j++)
                {
                    if (tiles[j] != null)
                    {
                        if (tiles[i].number > tiles[j].number)
                        {
                            thisTileInvertion++;
                        }
                    }
                }
                inversionsSum += thisTileInvertion;
            }
            return inversionsSum;
        }
    }
}
