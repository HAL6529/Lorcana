using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_14 : CardInfo
{
    public CardInfo_185_JA_14()
    {
        this.cardNo = "185_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アーサー";
        this.cardName2 = "鍛冶屋の見習い";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
