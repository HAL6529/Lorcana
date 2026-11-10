using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_04 : CardInfo
{
    public CardInfo_151_JA_04()
    {
        this.cardNo = "151_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "パスカル";
        this.cardName2 = "キョロキョロペット";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
