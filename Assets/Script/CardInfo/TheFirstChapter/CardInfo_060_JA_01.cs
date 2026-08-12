using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_060_JA_01 : CardInfo
{
    public CardInfo_060_JA_01()
    {
        this.cardNo = "060_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉCÉYÉ}";
        this.cardName2 = "òBã‡èpét!";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Hadjie Joos";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
