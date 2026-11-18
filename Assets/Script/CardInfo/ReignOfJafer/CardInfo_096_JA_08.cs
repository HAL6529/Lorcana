using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_096_JA_08 : CardInfo
{
    public CardInfo_096_JA_08()
    {
        this.cardNo = "096_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ナポレオン";
        this.cardName2 = "利口なブラッドハウンド";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
