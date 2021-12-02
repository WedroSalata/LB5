using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5
{
    class Container
    {
        private PictureBox pictBox;
        private List<Shape> shapes;
        public Container(PictureBox _pictBox)
        {
            pictBox = _pictBox;
            shapes = new List<Shape>();
        }

        public void Draw()
        {
            for (int index = 0; index < shapes.Count; index++)
            {
                shapes[index].Draw(pictBox);
            }
        }
        public List<Shape> GetList()
        {
            return shapes;
        }
        public Shape this[int i]
        {
            get { return shapes[i]; }
        }
        public void Add(int type, float x, float y, float width, float heigth, int color)
        {
            AddAt(type, x, y, width, heigth, color, shapes.Count);
        }
        public void AddAt(int type, float x, float y, float width, float heigth, int color, int index)
        {
            if (type == -1) { type = 0; }
            Shape ob;
            switch (type)
            {
                case 0:
                    ob = new Shapes.Rectangle(type, x, y, width, heigth, color);
                    shapes.Insert(index, ob);
                    break;
            }
        }
    }
}
