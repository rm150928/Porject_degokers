﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers
{
    public class Stork
    {
        private int _startingPosition;
        public int _maxSpeed;
        public int StartingPosition
        {
            get { return _startingPosition; }
            set { _startingPosition = value; }
        }

        private int _raceTrackLength;

        public int RaceTrackLength
        {
            get { return _raceTrackLength; }
            set { _raceTrackLength = value; }
        }

        private int _location;

        public int Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private PictureBox _myPictureBox;

        public PictureBox MyPictureBox
        {
            get { return _myPictureBox; }
            set { _myPictureBox = value; }
        }

        private Random _myRandom;

        public Random MyRandom
        {
            get { return _myRandom; }
            set { _myRandom = value; }
        }

        public bool Run(int _maxSpeed)
        {
            this._maxSpeed = _maxSpeed;
            int randomDistance = this._myRandom.Next(-1, this._maxSpeed);
            this._location += randomDistance;

            Point p = this._myPictureBox.Location;

            if (p.X > this._raceTrackLength)
            {
                return true;
            }
            else
            {
                p.X += randomDistance;
                this._myPictureBox.Location = p;

                return false;
            }
        }

        public void TakeStartingPosition()
        {
            this._location = this._startingPosition;

            Point p = this._myPictureBox.Location;
            p.X = Location;
            this._myPictureBox.Location = p;

            this.MyPictureBox.ImageLocation = @"images/Ooievaar.jpg";
        }
    }
}
