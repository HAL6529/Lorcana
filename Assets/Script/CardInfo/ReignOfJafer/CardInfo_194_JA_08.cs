using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_08 : CardInfo
{
    public CardInfo_194_JA_08()
    {
        this.cardNo = "194_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ヴィニー";
        this.cardName2 = "緑のハト";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
