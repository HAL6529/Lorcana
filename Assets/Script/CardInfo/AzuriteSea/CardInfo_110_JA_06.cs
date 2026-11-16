using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_06 : CardInfo
{
    public CardInfo_110_JA_06()
    {
        this.cardNo = "110_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ヴァネロペ・フォン・シュウィーツ";
        this.cardName2 = "ガッツある頑張り屋";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AriannaRea;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Racer};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
