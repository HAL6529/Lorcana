using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_02 : CardInfo
{
    public CardInfo_111_JA_02()
    {
        this.cardNo = "111_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "トレメイン夫人";
        this.cardName2 = "高圧的な家長";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
