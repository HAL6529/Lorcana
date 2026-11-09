using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_02 : CardInfo
{
    public CardInfo_138_JA_02()
    {
        this.cardNo = "138_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "バジル";
        this.cardName2 = "偉大なネズミの探偵";
        this.power = 3;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.BillRobinson;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
