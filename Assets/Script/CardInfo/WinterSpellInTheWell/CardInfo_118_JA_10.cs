using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_10 : CardInfo
{
    public CardInfo_118_JA_10()
    {
        this.cardNo = "118_JA_10";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ヘラクレス";
        this.cardName2 = "力強きリーダー";
        this.power = 5;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AmandaMacFarlane;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
