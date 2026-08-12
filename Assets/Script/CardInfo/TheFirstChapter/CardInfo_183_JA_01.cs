using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_01 : CardInfo
{
    public CardInfo_183_JA_01()
    {
        this.cardNo = "183_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クロンク";
        this.cardName2 = "イズマの用心棒";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Jake Parker";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
