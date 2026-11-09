using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_02 : CardInfo
{
    public CardInfo_157_JA_02()
    {
        this.cardNo = "157_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "プリンス・チャーミング";
        this.cardName2 = "王位継承者";
        this.power = 3;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.VickeyXieAndMarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
