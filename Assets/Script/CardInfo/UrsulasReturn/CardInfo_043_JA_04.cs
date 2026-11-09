using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_04 : CardInfo
{
    public CardInfo_043_JA_04()
    {
        this.cardNo = "043_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "フロットサム";
        this.cardName2 = "アースラの”かわいい子分”";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
