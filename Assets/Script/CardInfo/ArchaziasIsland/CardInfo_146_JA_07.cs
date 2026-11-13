using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_07 : CardInfo
{
    public CardInfo_146_JA_07()
    {
        this.cardNo = "146_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "エドガー・バルタザール";
        this.cardName2 = "野心を抱いた執事";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
