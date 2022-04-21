﻿namespace CalculatorFinalProject {
    public class ModeTracker {
        private string mode = "decimal";
        private List<char> validKeys;

        public string Mode {
            get {
                return mode;
            }
            set {
                mode = value;
                setValidKeys();
            }
        }

        public ModeTracker() {
            setValidKeys();
        }

        private void setValidKeys() {
            if (mode == "decimal") {
                validKeys = new List<char> {
                    '1','2','3','4','5','6','7','8','9','0',
                    '/','*','+','-','.','(',')'
                };
            }
            else if (mode == "hex") {
                validKeys = new List<char> {
                    '1','2','3','4','5','6','7','8','9','0',
                    '/','*','+','-','(',')'
                };
            }
            else if (mode == "binary") {
                validKeys = new List<char> {
                    '1','2','3','4','5','6','7','8','9','0',
                    '/','*','+','-','(',')','A','B','C','D',
                    'E','F','a','b','c','d','e','f'
                };
            }
        }

    }
}
