using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_01 : CardInfo
{
    public CardInfo_045_JA_01()
    {
        this.cardNo = "045_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "邪悪な魔法使い";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Jake Parker";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
