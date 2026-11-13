using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_060_JA_07 : CardInfo
{
    public CardInfo_060_JA_07()
    {
        this.cardNo = "060_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "バッキー";
        this.cardName2 = "人ナッツこいいたずら者";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
