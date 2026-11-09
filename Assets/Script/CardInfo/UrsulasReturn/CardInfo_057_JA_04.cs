using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_04 : CardInfo
{
    public CardInfo_057_JA_04()
    {
        this.cardNo = "057_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉAÅ[ÉXÉâ";
        this.cardName2 = "çrÇÍã∂Ç§äCÇÃñÇèó";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AdamFord;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>{ EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
