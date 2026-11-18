using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_08 : CardInfo
{
    public CardInfo_092_JA_08()
    {
        this.cardNo = "092_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フレッド";
        this.cardName2 = "科学愛好家";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JaredNickerlAndPatriBalanovsky;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
