using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_003_JA_13 : CardInfo
{
    public CardInfo_003_JA_13()
    {
        this.cardNo = "003_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "イサベラ・マドリガル";
        this.cardName2 = "花咲かお嬢さん";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LinhDang;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
