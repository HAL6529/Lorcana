using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_13 : CardInfo
{
    public CardInfo_181_JA_13()
    {
        this.cardNo = "181_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ノッティンガムのシェリフ";
        this.cardName2 = "つる刈り悪代官";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
