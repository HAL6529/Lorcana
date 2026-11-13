using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_126_JA_07 : CardInfo
{
    public CardInfo_126_JA_07()
    {
        this.cardNo = "126_JA_07";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "腕利きメカニック";
        this.power = 7;
        this.toughness = 7;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift7 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
