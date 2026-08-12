using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_01 : CardInfo
{
    public CardInfo_077_JA_01()
    {
        this.cardNo = "077_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジーニー";
        this.cardName2 = "ホンモノの中のホンモノ!";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Matt Chapman";
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
