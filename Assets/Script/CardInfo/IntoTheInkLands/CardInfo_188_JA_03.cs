using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_03 : CardInfo
{
    public CardInfo_188_JA_03()
    {
        this.cardNo = "188_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉâÉYÅ[Éã";
        this.cardName2 = "ã{ìaÇÃâqï∫";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KuyaJaypi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
