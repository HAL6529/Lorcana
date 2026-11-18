using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_08 : CardInfo
{
    public CardInfo_124_JA_08()
    {
        this.cardNo = "124_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヴァネロペ・フォン・シュウィーツ";
        this.cardName2 = "爆速スピードスター";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
