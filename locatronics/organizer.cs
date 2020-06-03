using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locatronics
{
    // organizer > racks > cells > baskets > chambers
    public class organizer
    {
        private int SearchStringMinimumLength = 2;
        public List<rack> racks = new List<rack>();

        public organizer()
        {
            rack r1 = new rack();
            this.setupR1(ref r1);

            racks.Add(r1);
        }

        /**
         * Define baskets in Rack #1
         * Database or Inventory of Items
         */
        private void setupR1(ref rack rack)
        {
            // ??
            rack.cell(111, "Black Red Soft Plastic Coated Testing Probe Aligator Clips Crocodile P2001");
            rack.cell(112, "5.08mm 2 Pin Connect Terminal Screw Terminal Connector KF301-2P");
            rack.cell(113, "Pitch jumper shorted cap & Headers & Wire Housings 2.54MM SHUNT");
            rack.cell(114, "T type 9V DC Battery Power Cable Barrel Jack Connector");
            rack.cell(115, "Snap on 9V Battery Holder Clip Connector Hard Shell 10CM Cable Lead");
            rack.cell(116, "Plastic ABS Enclosure Protective Case shell Transparent For UNO R3 Arduino");

            // LEDs and Diodes
            rack.cell(121, "Red LED");
            rack.cell(122, "Green LED");
            rack.cell(123, "Blue LED");
            rack.cell(124, "RGB Common Cathode LED");
            rack.cell(125, "RGB Common Anode LED");
            rack.cell(126, "3mm LED Light White Yellow Red Blue Green Assortment Diodes");
            rack.cell(127, "IR Emitter TSAL6100 6100 Emitter IR 5Mm Hi Eff 940nm ");
            rack.cell(128, "Laser Diode LED");
            rack.cell(129, "1A 1000V Diode 1N4007 IN4007 DO-41 Rectifier Diodes");

            // Resistors - Variable Values
            rack.cell(131, "Resistors - Low");
            rack.cell(132, "Resistors - Medium");
            rack.cell(133, "Resistors - High");
            rack.cell(134, "Dual stereo Potentiometer 3 pin");
            rack.cell(135, "Potentiometer Palstic Knob");

            // Capacitors - Variable Values
            rack.cell(141, "Capacitors - Low");
            rack.cell(142, "Capacitors - Medium");
            rack.cell(143, "Capacitors - High");

            // Sensors and Switches
            rack.cell(151, "LDR 5mm");
            rack.cell(152, "IR Sensor HS0038B HS0038 Sip3 Infrared Receiver To-92 Ir Receiver New Diy Ic I");
            rack.cell(153, "Reed Switch");
            rack.cell(154, "DIP Switch");
            rack.cell(155, "Push Button Switch");

            // External Devices
            rack.cell(161, "Magnets");
            rack.cell(162, "RTC Real Time Clock");
            rack.cell(163, "Crystal Oscillator");
            rack.cell(164, "FT232RL FTDI Serials Adapter Module");
            rack.cell(165, "Wireless Adapter Network LAN Card 802.11n/g/b OY");
            rack.cell(166, "USB 3.0 Female Header to 9 Pin USB 2.0 Male Motherboard adapter Cable");
            rack.cell(167, "Multimeter, Volt-meter, A-meter");
            rack.cell(168, "Network Cable Tester");

            // Wiring
            rack.cell(171, "Solderless MB-102 MB102 Breadboard 830 Tie Point PCB BreadBoard");
            rack.cell(172, "MB102 Breadboard Power Supply Module 3.3V/5V For Arduino Breadboard");
            rack.cell(173, "Dupont Jumper Cables Male to Male + Male to Female + Female to Female");
            rack.cell(174, "Dupont Short Jumber Cables");
            rack.cell(175, "Breadboard 400 Contacts");
            rack.cell(176, "GPIO Ribbon Cable");
            rack.cell(177, "Mini Micro JST Set");
            rack.cell(178, "Rainbow Ribbon Cable 10 way");
            rack.cell(179, "9V Battery Clips");
            rack.cell(180, "Aligator Clips");


            // Computer Boards
            rack.cell(181, "Arduino Uno Board");
            rack.cell(182, "Arduino Mini / Nano Board");
            rack.cell(183, "Arduino Mega Board");
            rack.cell(184, "Raspberry Pi 3 Board");
            rack.cell(185, "Raspberry Pi 4 Board");

            // Connectors
            rack.cell(191, "Breakable Male Header Pins");
            rack.cell(192, "Breakable Female Header Pins");
            rack.cell(193, "USB Solder");
            rack.cell(194, "Normal Solder");
            rack.cell(195, "Heat Shrink Tube");

            // Integrated Circuits
            rack.cell(201, "ATMEGA328P-PU");
            rack.cell(202, "NE555");
            rack.cell(203, "SN74HC595N 74HC595 8-Bit Shift Register DIP-16 IC");
            rack.cell(204, "BC547 TO-92 NPN 45V 0.1A Transistor");

            // Soldering
            rack.cell(211, "Cable Tester+Crimp Crimper");
            rack.cell(212, "Tin Lead Rosin Core Soldering / Welding Wire FLUX 2.0%");
            rack.cell(213, "Rainbow Ribbon IDC Cable Wire Rainbow Cable");
            rack.cell(214, "Multi Tester AC DC Voltmeter Ohmmeter Electrical Digital Multimeter DT-830B");
            rack.cell(215, "DIP IC Socket PCB Mount Connector");
            rack.cell(216, "100m Red Magnet Wire 0.2mm Enameled Copper Wire Round Magnetic Coil Winding");

            // Power Tools
            rack.cell(221, "4 Channel Relay Module With Optocoupler");
            rack.cell(222, "8 Channel Relay Module With Optocoupler");
            rack.cell(223, "5V 1/2/4/6/8 Channel Relay Board Module Optocoupler LED for Arduino PiC ARM AVR");
            rack.cell(224, "L317 LM317 LM317T TO-220 Voltage Regulator 1.2V To 37V 1.5A");
            rack.cell(225, "5 Way Spring Lever Terminal Block Electric Cable Wire Connector PCT-215");
            rack.cell(226, "AC Max 110~250V 2A In-line ON/OFF Table Lamp Desk Bed Light Cord Switch");
            rack.cell(227, "Prototype Paper PCB Universal Board");
            rack.cell(228, "Cute Flexible USB LED Light Mini Lamp For Computer Notebook Laptop PC Power Bank");

            // ??
            rack.cell(231, "UID Changeable Sector 0 Block 0 Writable 13.56Mhz RFID Proximity Smart Card");
            rack.cell(232, "RFID IC Keyfobs Key Tags Token NFC TAG Keychain 13.56MHz for Arduino");
            rack.cell(233, "125Khz USB RFID Contactless Proximity Sensor Smart ID Card Reader EM4100");
            rack.cell(234, "Network Cable Plug Connectors RJ45 Modular Female Couplers Module");
            rack.cell(235, "2000DPI Mice Optical Mouse Cordless USB Receiver PC Laptop Wireless Mice - Red");
            rack.cell(236, "2000DPI Mice Optical Mouse Cordless USB Receiver PC Laptop Wireless Mice - Yellow");

            // Tools
            // Also, see devices
            rack.cell(241, "Wire Cutter");
            rack.cell(242, "Wire Striper");
            rack.cell(243, "Wire Crimper Network Cable Crimper");
            rack.cell(244, "Network cable de-sheller");
            rack.cell(245, "Tweezers");

            // Plugs and Sockets
            rack.cell(251, "Type A male female USB Sockets");

            // Batteries
            rack.cell(261, "AA Battery");
            rack.cell(262, "AAA Battery");
            rack.cell(263, "9V Battery");
            rack.cell(264, "2032 Battery");

            // Set of Tool Boxes
            rack.cell(271, "Plastic Organizer Toolbox 1 - Single Use");
            rack.cell(272, "Plastic Organizer Toolbox 2 - Backup devices");
        }

        /**
         * Search
         */
        public List<basket> search(string component)
        {
            component = component.ToUpper();

            // in each racks
            // if basket contains partial component name
            // install

            List<basket> search = new List<basket>();

            // do not take care of too small string search
            if (component.Length >= SearchStringMinimumLength)
            {
                // for each racks
                foreach (rack rack in racks)
                {
                    foreach (basket b in rack.baskets)
                    {
                        if (b.contents.Contains(component))
                        {
                            search.Add(b);
                        }
                    }
                }
            }

            return search;
        }

        /**
         * Generates a full product names for a given search string
         */
        public List<string> preview(string component)
        {
            component = component.ToUpper();

            List<string> names = new List<string>();

            // do not take care of too small string search
            // for each items, if partial names matches, return strings
            if (component.Length >= SearchStringMinimumLength)
            {
                foreach (rack rack in racks)
                {
                    foreach (basket b in rack.baskets)
                    {
                        if (b.contents.Contains(component))
                        {
                            /**
                             * @todo Send LED light on signal to this cell
                             */
                            names.Add(b.contents);
                        }
                    }
                }
            }

            return names;
        }
    }
}
