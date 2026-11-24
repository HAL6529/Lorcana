using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_12 : CardInfo
{
    public CardInfo_074_JA_12()
    {
        this.cardNo = "074_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "おそろしの森の魔女";
        this.cardName2 = "奇天烈な木彫りのおばあさん";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
