using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_05 : CardInfo
{
    public CardInfo_071_JA_05()
    {
        this.cardNo = "071_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "リトル・ジョン";
        this.cardName2 = "キャンプのコック";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JohnLoren;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
