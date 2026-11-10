using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_159_JA_04 : CardInfo
{
    public CardInfo_159_JA_04()
    {
        this.cardNo = "159_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ƒgƒŠƒgƒ“‰¤";
        this.cardName2 = "Œ«–¾‚È‚é‰¤";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
