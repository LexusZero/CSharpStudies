using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    // отвечает за хранение/перемещение всех объектов с координатами
    // TODO
    class WorldMap : IWorldMap
    {
        private Smile[] smiles;
        private Teleporter[] teleporters;

        public WorldMap(Coords[] smilesCoords, string[] smileFaces, Coords[] teleportersCoords)
        {
            FillSmiles(smilesCoords, smileFaces);
            FillTeleporters(teleportersCoords);
        }

        private void FillSmiles(Coords[] smilesCoords, string[] smileFaces)
        {
            // TODO
            // заполнить массив smiles
        }

        private void FillTeleporters(Coords[] teleportersCoords)
        {
            // TODO
            // заполнить массив teleporters
        }

        // печатает карту мира (все объекты) в консоли
        public void Print()
        {
            // TODO
            // нужно будет вызывать PrintMoveable
            throw new NotImplementedException();
        }

        private void PrintMoveable(IMoveable moveable)
        {
            // TODO
            // печатает объект по координатам
        }

        private int current;
        // обновляет состояние объектов в мире
        public void Update(char key)
        {
            // TODO
            // НЕЛЬЗЯ НИ В КОЕМ СЛУЧАЕ ВЫЗЫВАТЬ Console.Write или другие Console.*
            throw new NotImplementedException();
        }
    }
}
