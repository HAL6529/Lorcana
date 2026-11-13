using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_168_JA_07 : CardInfo
{
    public CardInfo_168_JA_07()
    {
        this.cardNo = "168_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "‚»‚Î‚©‚·";
        this.cardName2 = "‚¢‚¢Žq‚É‚·‚é‚æ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LauraPauselli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
