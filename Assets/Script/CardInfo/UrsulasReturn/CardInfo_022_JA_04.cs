using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_04 : CardInfo
{
    public CardInfo_022_JA_04()
    {
        this.cardNo = "022_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "エリック王子";
        this.cardName2 = "アースラの花婿";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
